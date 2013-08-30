using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace DubstepSimulator.Options
{
    class GameOptions
    {

        private static int trackSegments;
        public static int TrackSegments
        {
            get { return GameOptions.trackSegments; }
            set { GameOptions.trackSegments = value; }
        }

        private static float wubDifference;
        public static float WubDifference
        {
            get { return GameOptions.wubDifference; }
            set { GameOptions.wubDifference = value; }
        }

        private static Vector2 resolution;
        public static Vector2 Resolution
        {
            get { return GameOptions.resolution; }
            set { GameOptions.resolution = value; }
        }

        private static float sfxVolume;
        public static float SFXVolume
        {
            get { return GameOptions.sfxVolume; }
            set { GameOptions.sfxVolume = value; }
        }
        
        private static float bgmVolume;
        public static float BGMVolume
        {
            get { return GameOptions.bgmVolume; }
            set { GameOptions.bgmVolume = value; }
        }

        public static void Initialize()
        {
            Resolution = new Vector2(1600, 600);
            SFXVolume = 1.0f;
            BGMVolume = 1.0f;
            wubDifference = 0.0001f;
        }
    }
}
