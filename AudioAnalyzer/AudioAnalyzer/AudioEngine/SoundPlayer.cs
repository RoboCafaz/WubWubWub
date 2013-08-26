using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Dsp;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System.Windows.Forms;

namespace AudioAnalyzer.AudioEngine
{
    class SoundPlayer
    {
        private IWavePlayer waveOutDevice;
        private WaveStream mainOutputStream;
        private string fileName = null;
        private NotifyingSampleProvider sampleProvider;
        private WaveStream readerStream;
        private Boolean isPlaying = false;
        private int fftDataSize = 2048;
        public List<Complex[]> fftSamples;

        private SoundAggregator aggregator;
        private Complex[] curArray;
        private List<double[]> samples = new List<double[]>();
        private const int pointsPerGroup = 1;

        public Boolean IsPlaying
        {
            get { return isPlaying; }
            set { isPlaying = value; }
        }

        /// <summary>
        /// Initializes this instance of the SoundPlayer object.
        /// </summary>
        public void Initialize()
        {
            aggregator = new SoundAggregator(fftDataSize);

            try
            {
                waveOutDevice = new WaveOut();
            }
            catch (Exception driverCreateException)
            {
                MessageBox.Show(String.Format("{0}", driverCreateException.Message));
                return;
            }
        }

        /// <summary>
        /// Loads the visualization pixel images.
        /// </summary>
        /// <param name="content">The game's primary content manager.</param>
        public void LoadContent(ContentManager content)
        {

        }

        /// <summary>
        /// Loads up a song.
        /// </summary>
        /// <param name="fileName">Name of the song to load up.</param>
        public void LoadSong(String fileName)
        {
            this.fileName = fileName;
            this.fftSamples = new List<Complex[]>();
        }

        /// <summary>
        /// Initializes all input streams and begins playing back the song.
        /// </summary>
        public void PlaySong()
        {
            CreateInputStream(fileName);

            try
            {
                waveOutDevice.Init(new SampleToWaveProvider(sampleProvider));
            }
            catch (Exception initException)
            {
                MessageBox.Show(String.Format("{0}", initException.Message), "Error Initializing Output");
                return;
            }

            waveOutDevice.Play();
            waveOutDevice.Volume = 100;
            isPlaying = true;
        }

        /// <summary>
        /// Generates the input stream based on what kind of file it is.
        /// </summary>
        /// <param name="fileName">Name of the file about to be played.</param>
        private void CreateInputStream(string fileName)
        {
            SampleChannel inputStream;
            if (fileName.EndsWith(".wav"))
            {
                readerStream = new WaveFileReader(fileName);
                if (readerStream.WaveFormat.Encoding != WaveFormatEncoding.Pcm)
                {
                    readerStream = WaveFormatConversionStream.CreatePcmStream(readerStream);
                    readerStream = new BlockAlignReductionStream(readerStream);
                }
                if (readerStream.WaveFormat.BitsPerSample != 16)
                {
                    var format = new WaveFormat(readerStream.WaveFormat.SampleRate,
                         16, readerStream.WaveFormat.Channels);
                    readerStream = new WaveFormatConversionStream(format, readerStream);
                }
                inputStream = new SampleChannel(readerStream);
            }
            else if (fileName.EndsWith(".mp3"))
            {
                readerStream = new Mp3FileReader(fileName);
                inputStream = new SampleChannel(readerStream);
            }
            else
            {
                throw new InvalidOperationException("Unsupported extension");
            }
            sampleProvider = new NotifyingSampleProvider(inputStream);
            sampleProvider.Sample += (s, e) => aggregator.Add(e.Left, e.Right);
        }

        /// <summary>
        /// Closes the stream safely.
        /// </summary>
        public void CloseStream()
        {
            isPlaying = false;
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
            }
            if (readerStream != null)
            {
                readerStream.Close();
                readerStream = null;
            }
            if (mainOutputStream != null)
            {
                // this one does the metering stream
                mainOutputStream.Close();
                mainOutputStream = null;
            }
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }
        }

        public void FFT_Done(Object sender, FftEventArgs e)
        {
            Complex[] result = e.Result;

            fftSamples.Add(result);
            curArray = fftSamples.Last();

            if (fftSamples.Count > 0)
            {
                double[] allSamples = new double[result.Length];
                for (int i = 0; i < result.Length; i++)
                {
                    allSamples[i] = CalcDB(result[i]);
                }
                if (pointsPerGroup > 1)
                {
                    double[] sampleSet = new double[result.Length / pointsPerGroup];
                    for (int i = 0; i < sampleSet.Length; i++)
                    {
                        double avg = 0;
                        for (int j = 0; j < pointsPerGroup; j++)
                        {
                            avg += allSamples[(i * pointsPerGroup) + j];
                        }
                        avg /= pointsPerGroup;
                        sampleSet[i] = avg;
                    }
                    samples.Add(sampleSet);
                }
                else
                {
                    samples.Add(allSamples);
                }
            }
        }

        public void FFT_Maxed(Object sender, MaxSampleEventArgs e)
        {

        }

        public double CalcIntensity(Complex c)
        {
            return System.Math.Sqrt(c.X * c.X + c.Y * c.Y);
        }

        public double CalcDB(Complex c)
        {
            // in theory should be 20x to get the power, but doesn't seem to give me sensible values (may be because we throw half the FFT away - bin 0 might need to be halved)
            double intensityDB = 10 * System.Math.Log(System.Math.Sqrt(c.X * c.X + c.Y * c.Y));
            double minDB = -96;
            if (intensityDB < minDB)
            {
                intensityDB = minDB;
            }
            return intensityDB / minDB;
        }

        public Boolean GetFFTData(float[] fftBuffer)
        {
            aggregator.GetFFTResults(fftBuffer);
            return isPlaying;
        }

        public int GetFFTFrequencyIndex(int frequency)
        {
            double maxFrequency;
            if (isPlaying)
                maxFrequency = readerStream.WaveFormat.SampleRate / 2.0d;
            else
                maxFrequency = 22050; // Assume a default 44.1 kHz sample rate.
            return (int)((frequency / maxFrequency) * (fftDataSize / 2));
        }
    }
}