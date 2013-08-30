using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AudioAnalyzer.AudioEngine;
using Microsoft.Xna.Framework;
using AudioAnalyzer;
using DubstepSimulator.Graphics;

namespace DubstepSimulator.Audio
{
    class AudioHandler
    {
        private static SoundSpectrum soundSpectrum = new SoundSpectrum(new Rectangle(0, 0, 640, 480));
        private static SoundAggregator soundAggregator = new SoundAggregator(1024);
        private static SoundPlayer soundPlayer = new SoundPlayer();
        private static SoundPlayer SoundPlayer{ get{return soundPlayer;}}
        private static Dictionary<int,List<float[]>> data;
        public static Dictionary<int, List<float[]>> Data { get { return data; } }

        public static void Initialize()
        {
            soundPlayer.Initialize();
        }

        public static void LoadContent()
        {
            soundPlayer.LoadSong(@"C:\Users\bcafazzo\Music\MGR\03 vs. Mistral - A Stranger I Remain.mp3");
            soundSpectrum.AudioEvent += (s, e) => AudioEvent(e);
            data = soundPlayer.Analyze(4);
            //soundSpectrum.RegisterSoundPlayer(soundPlayer);
            soundPlayer.PlaySong();
        }

        public static void Update(GameTime gameTime)
        {
            soundSpectrum.Update(gameTime);
        }

        public static void UnloadContent()
        {
            soundPlayer.CloseStream();
        }

        private static void AudioEvent(AudioEventArgs e)
        {
            if (e.DataType == SpectrumType.LINEAR)
            {
                if (e.SpectrumPoint < 2)
                {
                    SpriteBatchHandler.reverseWubbing();
                }
                else if (e.SpectrumPoint < 8)
                {
                    SpriteBatchHandler.increaseWubitude();
                }
                else
                {
                    SpriteBatchHandler.decreaseWubitude();
                }
            }
        }
    }
}
