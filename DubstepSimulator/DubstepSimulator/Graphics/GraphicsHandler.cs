using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using DubstepSimulator.Options;

namespace DubstepSimulator.Graphics
{
    class GraphicsHandler
    {
        private static GraphicsDeviceManager graphics;

        public static void Initialize(ref GraphicsDeviceManager graphics)
        {
            GraphicsHandler.graphics = graphics;
            graphics.PreferredBackBufferWidth = (int)GameOptions.Resolution.X;
            graphics.PreferredBackBufferHeight = (int)GameOptions.Resolution.Y;
            graphics.ApplyChanges();
        }
    }
}
