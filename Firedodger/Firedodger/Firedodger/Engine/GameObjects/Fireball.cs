using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firedodger.Constants;
using Microsoft.Xna.Framework;
using Firedodger.Handlers;

namespace Firedodger.Engine.GameObjects
{
    class Fireball : GameObject
    {
        private int _speed;

        public Fireball(SpriteID spriteId, Vector2 pos, double scale, int speed)
            : base(spriteId, pos, scale)
        {
            this._speed = speed;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            this.Pos = new Vector2(this.Pos.X, this.Pos.Y + _speed);
            if(this.Bounding.Intersects(GameObjectHandler.Get(1).Bounding))
            {
                int i = GameObjectHandler.random.Next(0,10);
                SoundID toPlay;
                if(i >= 5)
                {
                    toPlay = SoundID.FIRE_ONE;
                }
                else
                {
                    toPlay = SoundID.FIRE_TWO;
                }
                SoundHandler.PlaySound(toPlay);
                if (Game1.score > 0)
                {
                    Game1.score--;
                }
                this.Destroy();
            }
        }
    }
}
