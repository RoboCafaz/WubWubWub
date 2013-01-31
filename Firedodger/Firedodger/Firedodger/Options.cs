using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Firedodger
{
    class Options
    {
        // Width of game window.
        private static int windowWidth = 1024;

        // Height of game window.
        private static int windowHeight = 768;

        // Fullscreen window?
        private static Boolean fullscreen = false;

        // Width-to-height ratio.
        private static double ratio = windowWidth / windowHeight;

        // Volume at which to play BGM.
        private static int musicVolume = 100;

        // Volume at which to play SFX.
        private static int soundVolume = 100;

        // Amount of particle effects to render.
        private static int graphicalIntensity = 100;

        // Size (in pixels) of tiles.
        private static int tileSize = 64;

        public static int WindowWidth
        {
            get { return windowWidth; }
            set { windowWidth = value; }
        }

        public static int WindowHeight
        {
            get { return windowHeight; }
            set { windowHeight = value; }
        }

        public static Boolean Fullscreen
        {
            get { return fullscreen; }
            set { fullscreen = value; }
        }

        public static double Ratio
        {
            get
            {
                ratio = windowWidth / windowHeight;
                return ratio;
            }
        }

        public static int MusicVolume
        {
            get { return musicVolume; }
            set { musicVolume = value; }
        }

        public static int SoundVolume
        {
            get { return soundVolume; }
            set { soundVolume = value; }
        }

        public static int GraphicalIntensity
        {
            get { return graphicalIntensity; }
            set { graphicalIntensity = value; }
        }

        public static int TileSize
        {
            get { return Options.tileSize; }
            set { Options.tileSize = value; }
        }
    }
}
