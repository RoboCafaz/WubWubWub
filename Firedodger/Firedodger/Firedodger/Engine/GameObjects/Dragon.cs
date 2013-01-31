using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firedodger.Constants;
using Microsoft.Xna.Framework;

namespace Firedodger.Engine.GameObjects
{
    class Dragon : GameObject
    {
        public Dragon(SpriteID spriteId, Vector2 pos, double scale)
            : base(spriteId, pos, scale)
        {
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (Game1.songTime >= 27.5)
            {
                this.Pos = new Vector2(this.Pos.X + 12, this.Pos.Y - 2);
            }
        }
    }
}
