using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firedodger.Constants;
using Microsoft.Xna.Framework;

namespace Firedodger.Engine.GameObjects
{
    class Inferno : GameObject
    {
        int offset = 0;

        public Inferno(SpriteID spriteId, Vector2 pos, double scale)
            : base(spriteId, pos, scale)
        {
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (Game1.songTime > 27 && this.Pos.Y > 668)
            {
                this.Pos = new Vector2(this.Pos.X, this.Pos.Y - 0.1f);
            }

            if (offset < 1024)
            {
                this.Pos = new Vector2(this.Pos.X + 1, this.Pos.Y);
                offset++;
            }
            else
            {
                this.Pos = new Vector2(this.Pos.X - offset, this.Pos.Y);
                offset = 0;
            }
        }
    }
}
