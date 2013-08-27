using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DubstepSimulator.Options;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace DubstepSimulator.Graphics
{
    class SpriteBatchHandler
    {
        private static Matrix wubMatrix;
        private static Texture2D baseSprite;
        private static float wubitude;

        public static void increaseWubitude()
        {
            wubitude += GameOptions.WubDifference;
        }

        public static void decreaseWubitude()
        {
            wubitude -= GameOptions.WubDifference;
        }

        public static void reverseWubbing()
        {
            wubitude *= -1;
        }

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
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Right))
            {
                wubitude += GameOptions.WubDifference;
            }
            else if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Left))
            {
                wubitude -= GameOptions.WubDifference;
            }
            wubMatrix *= Matrix.CreateTranslation(-(float)(GameOptions.Resolution.X / 2), -(float)(GameOptions.Resolution.Y / 2), 0);
            wubMatrix *= Matrix.CreateFromYawPitchRoll(0, 0, wubitude);
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
