using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Wave;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace AudioAnalyzer.AudioEngine
{
    public class SoundSpectrum
    {
        private int[] barHeights;
        private int[] peakHeights;
        private float[] channelData = new float[1024];
        private double bandWidth = 1.0;
        private int maximumFrequencyIndex = 1023;
        private int minimumFrequencyIndex;
        private int[] barIndexMax;
        private int[] barLogScaleIndexMax;
        private int maximumFrequency;
        private int minimumFrequency;
        private int barCount = 31;
        private int barSpacing = 2;
        private int barWidth = 14;
        private int peakFallDelay = 120;
        private Rectangle canvas;
        private int interval = 0;
        private float buffer = 50;

        private float[] dbPeakData;
        private float[] linPeakData;
        private float[] sqrtPeakData;

        private List<Rectangle> dbBarShapes = new List<Rectangle>();
        private List<Rectangle> dbPeakShapes = new List<Rectangle>();
        private List<Rectangle> linBarShapes = new List<Rectangle>();
        private List<Rectangle> linPeakShapes = new List<Rectangle>();
        private List<Rectangle> sqrtBarShapes = new List<Rectangle>();
        private List<Rectangle> sqrtPeakShapes = new List<Rectangle>();

        private const int scaleFactorLinear = 9;
        private const int scaleFactorSquare = 2;
        private const double minDBValue = -90;
        private const double maxDBValue = 0;
        private const double dbScale = (maxDBValue - minDBValue);
        private const int defaultUpdateInterval = 1;
        private const int dataTypes = 3;

        private Boolean calcDb = true;
        private Boolean calcLin = true;
        private Boolean calcSqrt = true;

        private int realDataTypes;

        private SoundPlayer soundPlayer;

        public event AudioEventHandler AudioEvent;

        /// <summary>
        /// Maximum frequency of samples.
        /// </summary>
        public int MaximumFrequency
        {
            get { return maximumFrequency; }
            set
            {
                if (value > minimumFrequency)
                {
                    maximumFrequency = value;
                }
                else
                {
                    maximumFrequency = minimumFrequency + 1;
                }
            }
        }

        /// <summary>
        /// Minimum frequency of samples.
        /// </summary>
        public int MinimumFrequency
        {
            get { return minimumFrequency; }
            set
            {
                if (value > 0)
                {
                    minimumFrequency = value;
                }
                else
                {
                    minimumFrequency = 0;
                }
            }
        }

        /// <summary>
        /// Number of bars being rendered.
        /// </summary>
        public int BarCount
        {
            get { return barCount; }
            set
            {
                if (value > 0)
                {
                    barCount = value;
                }
                else
                {
                    barCount = 1;
                }
            }
        }

        public SoundSpectrum(Rectangle canvas)
        {
            this.canvas = canvas;
        }

        public void RegisterSoundPlayer(SoundPlayer soundPlayer)
        {
            this.soundPlayer = soundPlayer;
            SetupBars();
        }

        public void Update(GameTime gameTime)
        {
            if (soundPlayer != null && soundPlayer.IsPlaying)
            {
                interval++;
                if (interval >= defaultUpdateInterval && soundPlayer.GetFFTData(channelData))
                {
                    NewSpectrumUpdate();
                    interval = 0;
                }
            }
        }

        private void NewSpectrumUpdate()
        {
            int barIndex = 0;

            double dbHeight = 0;
            double linHeight = 0;
            double sqrtHeight = 0;

            double dbPeakYPos;
            double linPeakYPos;
            double sqrtPeakYPos;

            double maxHeight = canvas.Height;
            double peakDotHeight = Math.Max(barWidth / 6.0f, 1);
            double barHeightScale = maxHeight - peakDotHeight;

            for (int i = minimumFrequencyIndex; i <= maximumFrequencyIndex; i++)
            {
                int currentIndexMax = currentIndexMax = barLogScaleIndexMax[barIndex];
                if (i == currentIndexMax)
                {
                    if (!soundPlayer.IsPlaying)
                    {
                        dbHeight = 0;
                        linHeight = 0;
                        sqrtHeight = 0;
                    }
                    else
                    {
                        double xCoord = canvas.Left + barSpacing + (barWidth * barIndex) + (barSpacing * barIndex) + 1;

                        if (calcDb)
                        {
                            // DB Scale
                            double dbValue = 20 * System.Math.Log10((double)channelData[i]);
                            dbHeight = ((dbValue - minDBValue) / dbScale) * barHeightScale;
                            dbHeight = Math.Max(0, dbHeight);
                            dbHeight = Math.Min(dbHeight, maxHeight);
                            dbPeakYPos = dbHeight;

                            if (dbPeakData[barIndex] < dbPeakYPos)
                            {
                                dbPeakData[barIndex] = (float)dbPeakYPos + buffer;
                                AudioEvent(this, new AudioEventArgs(barIndex, SpectrumType.DECIBAL, dbPeakYPos));
                            }
                            else
                            {
                                dbPeakData[barIndex] = (float)(dbPeakYPos + (peakFallDelay * dbPeakData[barIndex])) / ((float)(peakFallDelay + 1));
                            }

                            dbBarShapes[barIndex] = new Rectangle((int)xCoord, (int)0, (int)barWidth, (int)dbHeight);
                            dbPeakShapes[barIndex] = new Rectangle((int)xCoord, (int)(dbPeakData[barIndex] + peakDotHeight), (int)barWidth, (int)peakDotHeight);

                            dbHeight = 0;
                        }

                        if (calcLin)
                        {
                            linHeight = (channelData[i] * scaleFactorLinear) * barHeightScale;
                            linHeight = Math.Max(0, linHeight);
                            linHeight = Math.Min(linHeight, maxHeight);
                            linPeakYPos = linHeight;

                            if (linPeakData[barIndex] < linPeakYPos)
                            {
                                linPeakData[barIndex] = (float)linPeakYPos + buffer;
                                AudioEvent(this, new AudioEventArgs(barIndex, SpectrumType.LINEAR, linPeakYPos));
                            }
                            else
                            {
                                linPeakData[barIndex] = (float)(linPeakYPos + (peakFallDelay * linPeakData[barIndex])) / ((float)(peakFallDelay + 1));
                            }

                            linBarShapes[barIndex] = new Rectangle((int)xCoord, (int)0, (int)barWidth, (int)linHeight);
                            linPeakShapes[barIndex] = new Rectangle((int)xCoord, (int)(linPeakData[barIndex] + peakDotHeight), (int)barWidth, (int)peakDotHeight);

                            linHeight = 0;

                        }

                        if (calcSqrt)
                        {
                            sqrtHeight = (((Math.Sqrt((double)channelData[i])) * scaleFactorSquare) * barHeightScale);
                            sqrtHeight = Math.Max(0, sqrtHeight);
                            sqrtHeight = Math.Min(sqrtHeight, maxHeight);
                            sqrtPeakYPos = sqrtHeight;

                            if (sqrtPeakData[barIndex] < sqrtPeakYPos)
                            {
                                sqrtPeakData[barIndex] = (float)sqrtPeakYPos + buffer;
                                AudioEvent(this, new AudioEventArgs(barIndex, SpectrumType.SQUARE, sqrtPeakYPos));
                            }
                            else
                            {
                                sqrtPeakData[barIndex] = (float)(sqrtPeakYPos + (peakFallDelay * sqrtPeakData[barIndex])) / ((float)(peakFallDelay + 1));
                            }

                            sqrtBarShapes[barIndex] = new Rectangle((int)xCoord, (int)0, (int)barWidth, (int)sqrtHeight);
                            sqrtPeakShapes[barIndex] = new Rectangle((int)xCoord, (int)(sqrtPeakData[barIndex] + peakDotHeight), (int)barWidth, (int)peakDotHeight);

                            sqrtHeight = 0;
                        }
                        barIndex++;
                    }
                }
            }
        }

        /// <summary>
        /// Sets up bars for processing.
        /// </summary>
        private void SetupBars()
        {
            realDataTypes = 0;
            if (calcDb)
            {
                realDataTypes++;
            }

            if (calcLin)
            {
                realDataTypes++;
            }

            if (calcSqrt)
            {
                realDataTypes++;
            }

            if (soundPlayer == null)
            {
                return;
            }
            MaximumFrequency = 1023;

            barWidth = (int)System.Math.Max((double)(canvas.Width - (barSpacing * barCount + 1)) / (double)barCount, 1);
            maximumFrequencyIndex = System.Math.Min(soundPlayer.GetFFTFrequencyIndex(MaximumFrequency) + 1, 1023);
            minimumFrequencyIndex = System.Math.Min(soundPlayer.GetFFTFrequencyIndex(MinimumFrequency), 1023);
            bandWidth = System.Math.Max(((double)(maximumFrequencyIndex - minimumFrequencyIndex)) / canvas.Width, 1.0);

            int actualBarCount;
            if (barWidth >= 1)
            {
                actualBarCount = barCount;
            }
            else
            {
                actualBarCount = System.Math.Max((int)((canvas.Width - barSpacing) / (barWidth + barSpacing)), 1);
            }
            dbPeakData = new float[actualBarCount];
            linPeakData = new float[actualBarCount];
            sqrtPeakData = new float[actualBarCount];

            int indexCount = maximumFrequencyIndex - minimumFrequencyIndex;
            int linearIndexBinSize = (int)System.Math.Round((double)indexCount / (double)actualBarCount, 0);
            List<int> maxIndexList = new List<int>();
            List<int> maxLogScaleIndexList = new List<int>();
            double maxLog = System.Math.Log(actualBarCount, actualBarCount);
            for (int i = 1; i < actualBarCount; i++)
            {
                maxIndexList.Add(minimumFrequencyIndex + (i * linearIndexBinSize));
                int logIndex = (int)((maxLog - System.Math.Log((actualBarCount + 1) - i, (actualBarCount + 1))) * indexCount) + minimumFrequencyIndex;
                maxLogScaleIndexList.Add(logIndex);
            }
            maxIndexList.Add(maximumFrequencyIndex);
            maxLogScaleIndexList.Add(maximumFrequencyIndex);
            barIndexMax = maxIndexList.ToArray();
            barLogScaleIndexMax = maxLogScaleIndexList.ToArray();

            barHeights = new int[actualBarCount];
            peakHeights = new int[actualBarCount];

            dbBarShapes.Clear();
            dbPeakShapes.Clear();
            linBarShapes.Clear();
            linPeakShapes.Clear();
            sqrtBarShapes.Clear();
            sqrtPeakShapes.Clear();

            double height = canvas.Height;
            double peakDotHeight = System.Math.Max(barWidth / 2, 1);

            for (int i = 0; i < actualBarCount; i++)
            {
                double xCoord = barSpacing + (barWidth * i) + (barSpacing * i) + 1;
                Rectangle barRectangle = new Rectangle((int)xCoord, (int)0, (int)barWidth, 0);
                dbBarShapes.Add(barRectangle);
                linBarShapes.Add(barRectangle);
                sqrtBarShapes.Add(barRectangle);
                Rectangle peakRectangle = new Rectangle((int)xCoord, (int)(peakDotHeight), (int)barWidth, 0);
                dbPeakShapes.Add(peakRectangle);
                linPeakShapes.Add(peakRectangle);
                sqrtPeakShapes.Add(peakRectangle);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Rectangle r in dbBarShapes)
            {
                Rectangle repos = new Rectangle(r.X, canvas.Y + canvas.Height - r.Height, (int)((double)r.Width / realDataTypes), r.Height);
                spriteBatch.Draw(Game1.pixel, repos, Color.LimeGreen);
            }
            foreach (Rectangle r in dbPeakShapes)
            {
                Rectangle repos = new Rectangle(r.X, canvas.Y + canvas.Height - r.Y, (int)((double)r.Width / realDataTypes), r.Height);
                spriteBatch.Draw(Game1.pixel, repos, Color.Blue);
            }

            foreach (Rectangle r in linBarShapes)
            {
                Rectangle repos = new Rectangle(r.X + (int)((double)r.Width / realDataTypes), canvas.Y + canvas.Height - r.Height, (int)((double)r.Width / realDataTypes), r.Height);
                spriteBatch.Draw(Game1.pixel, repos, Color.Cyan);
            }
            foreach (Rectangle r in linPeakShapes)
            {
                Rectangle repos = new Rectangle(r.X + (int)((double)r.Width / realDataTypes), canvas.Y + canvas.Height - r.Y, (int)((double)r.Width / realDataTypes), r.Height);
                spriteBatch.Draw(Game1.pixel, repos, Color.Blue);
            }

            foreach (Rectangle r in sqrtBarShapes)
            {
                Rectangle repos = new Rectangle(r.X + (int)(((double)r.Width / realDataTypes) * 2), canvas.Y + canvas.Height - r.Height, (int)((double)r.Width / realDataTypes), r.Height);
                spriteBatch.Draw(Game1.pixel, repos, Color.Orange);
            }
            foreach (Rectangle r in sqrtPeakShapes)
            {
                Rectangle repos = new Rectangle(r.X + (int)(((double)r.Width / realDataTypes) * 2), canvas.Y + canvas.Height - r.Y, (int)((double)r.Width / realDataTypes), r.Height);
                spriteBatch.Draw(Game1.pixel, repos, Color.Red);
            }
        }
    }
}
