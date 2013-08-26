using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AudioAnalyzer
{
    class EventVisuals
    {
        List<EventVisual> visuals = new List<EventVisual>();

        public void CreateEvent(AudioEventArgs e)
        {
            visuals.Add(new EventVisual(e.SpectrumPoint, e.DataType));
        }

        public void Update(GameTime gameTime)
        {
            foreach (EventVisual vis in visuals)
            {
                    vis.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(EventVisual vis in visuals)
            {
                vis.Draw(spriteBatch);
            }
        }

        private class EventVisual
        {
            public EventVisual(int spectrumPoint, SpectrumType type)
            {
                point = spectrumPoint;
                switch (type)
                {
                    case SpectrumType.DECIBAL:
                        color = Color.White;
                        baseOffset = 0;
                        break;
                    case SpectrumType.LINEAR:
                        color = Color.Blue;
                        baseOffset = 280;
                        break;
                    case SpectrumType.SQUARE:
                        color = Color.Pink;
                        baseOffset = 560;
                        break;
                }
                color.A = 155;
            }

            private Color color;
            private int point;
            private int baseOffset;
            private int life = 100;
            public Boolean kill = false;

            public void Update(GameTime gameTime)
            {
                life--;
                if (life <= 0)
                {
                    this.kill = true;
                }
            }

            public void Draw(SpriteBatch spriteBatch)
            {
                if (!kill)
                {
                    float lifePer = (float)life / 100f;
                    spriteBatch.Draw(Game1.pixel, new Rectangle(baseOffset + (point * 9), GraphicsDeviceManager.DefaultBackBufferHeight - (int)(lifePer * GraphicsDeviceManager.DefaultBackBufferHeight), 8, 6), color);
                }
            }
        }
    }
}
