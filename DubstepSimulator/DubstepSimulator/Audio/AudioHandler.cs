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
        private static SoundAggregator soundAggregator = new SoundAggregator(2048);
        private static SoundPlayer soundPlayer = new SoundPlayer();

        public static void Initialize()
        {
            soundPlayer.Initialize();
        }

        public static void LoadContent()
        {
            soundPlayer.LoadSong(@"C:\Users\bcafazzo\Music\MGR\10 vs. Sundowner - Red Sun (Maniac A.mp3");
            soundSpectrum.AudioEvent += (s, e) => AudioEvent(e);
            soundPlayer.PlaySong();
            soundSpectrum.RegisterSoundPlayer(soundPlayer);
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
