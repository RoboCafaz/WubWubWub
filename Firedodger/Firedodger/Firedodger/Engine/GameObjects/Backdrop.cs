using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Firedodger.Constants;
using Firedodger.Graphics;
using Firedodger.Handlers;

namespace Firedodger.Engine.GameObjects
{
    class Backdrop : GameObject
    {
        public Backdrop(SpriteID spriteId, Vector2 pos, double scale)
            : base(spriteId, pos, scale)
        {
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            Vector3 colors = Sprite.Color.ToVector3();
            if (Game1.songTime >= 27.5 && Game1.songTime <= 31)
            {
                this.Sprite.Color = new Color(colors.X, colors.Y - 0.005f, colors.Z - 0.005f);
            }
            else if (Game1.songTime >= 69)
            {
                this.Sprite.Color = new Color(colors.X + (GameObjectHandler.random.Next(-4, 5) * 0.02f), colors.Y + (GameObjectHandler.random.Next(-4, 5) * 0.02f), colors.Z + (GameObjectHandler.random.Next(-4, 5) * 0.02f));
            }
        }
    }
}
