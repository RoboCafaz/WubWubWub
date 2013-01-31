using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DubstepSimulator.Options;
using Microsoft.Xna.Framework.Content;

namespace DubstepSimulator.Graphics
{
    class SpriteBatchHandler
    {
        private static Matrix wubMatrix;
        private static Texture2D baseSprite;

        public static void Initialize()
        {
            wubMatrix = Matrix.Identity;
        }

        public static void LoadContent(ContentManager content)
        {
            baseSprite = content.Load<Texture2D>("baseSprite");
        }

        public static void Update(GameTime gameTime)
        {
            wubMatrix *= Matrix.CreateTranslation(-(float)(GameOptions.Resolution.X / 2), -(float)(GameOptions.Resolution.Y / 2), 0);
            wubMatrix *= Matrix.CreateFromYawPitchRoll(0, 0, 0.005f);
            wubMatrix *= Matrix.CreateTranslation((float)(GameOptions.Resolution.X / 2), (float)(GameOptions.Resolution.Y / 2), 0);
        }

        public static void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.LinearClamp, DepthStencilState.Default, RasterizerState.CullNone, null, wubMatrix);
            spriteBatch.Draw(baseSprite, new Rectangle((int)(GameOptions.Resolution.X / 2), (int)(GameOptions.Resolution.Y / 2), 25, 25), Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            // TODO: Draw GUI.
            spriteBatch.End();
        }
    }
}
