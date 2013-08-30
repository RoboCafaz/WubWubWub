using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DubstepSimulator.Options;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using DubstepSimulator.Audio;

namespace DubstepSimulator.Graphics
{
    class SpriteBatchHandler
    {
        private static Matrix wubMatrix;
        public static Texture2D baseSprite;
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
            baseSprite = content.Load<Texture2D>("Photo0433");
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
            //spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.LinearClamp, DepthStencilState.Default, RasterizerState.CullNone, null, wubMatrix);
            //spriteBatch.Draw(baseSprite, new Rectangle((int)(GameOptions.Resolution.X / 2) - (baseSprite.Width / 2), (int)(GameOptions.Resolution.Y / 2) - (baseSprite.Height / 2), (baseSprite.Width), baseSprite.Height), Color.White);
            //spriteBatch.End();

            spriteBatch.Begin();
            float subs = AudioHandler.Data.Values.Count;
            int yBase = (int)(GameOptions.Resolution.Y / (subs));
            for (int i = 0; i < subs; i++)
            {
                float pos = 0;
                List<float[]> values;
                if (AudioHandler.Data.TryGetValue(i, out values))
                {
                    foreach (float[] v in values)
                    {
                        int top = (int)((yBase * (i+1)) - ((GameOptions.Resolution.Y * v[0]) / (subs*2)));
                        int bottom = (int)((yBase*(i+1)) - ((GameOptions.Resolution.Y * v[1]) / (subs*2)));
                        Rectangle rect = new Rectangle((int)pos, top, 1, bottom - top);
                        spriteBatch.Draw(baseSprite, rect, new Color(i * pos, i * pos, i * pos));
                        pos += 0.05f;
                    }
                }
            }
            spriteBatch.End();
        }
    }
}
