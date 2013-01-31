using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Firedodger.Constants;
using Microsoft.Xna.Framework.Input;
using Firedodger.Graphics;
using Microsoft.Xna.Framework.Graphics;
using Firedodger.Handlers;

namespace Firedodger.Engine.GameObjects
{
    class ControllableObject : GameObject
    {
        private PlayerIndex _owner;

        public ControllableObject(SpriteID spriteId, Vector2 pos, double scale, PlayerIndex owner)
            : base(spriteId, pos, scale)
        {
            this._owner = owner;
        }

        public ControllableObject(SpriteID spriteId, PlayerIndex owner)
            : base(spriteId)
        {
            this._owner = owner;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            this.Sprite.CurrentAnimation = 0;
            if (GamePad.GetState(_owner).IsButtonDown(Buttons.LeftThumbstickLeft) || Keyboard.GetState(_owner).IsKeyDown(Keys.Left))
            {
                if (Pos.X > 128)
                {
                    this.Pos = new Vector2(this.Pos.X - 5, this.Pos.Y);
                    this.Sprite.CurrentAnimation = 1;
                    this.Sprite.SpriteEffects = SpriteEffects.FlipHorizontally;
                }
            }
            else if (GamePad.GetState(_owner).IsButtonDown(Buttons.LeftThumbstickRight) || Keyboard.GetState(_owner).IsKeyDown(Keys.Right))
            {
                if (Pos.X < 1024 - 32 - 128)
                {
                    this.Pos = new Vector2(this.Pos.X + 5, this.Pos.Y);
                    this.Sprite.CurrentAnimation = 1;
                    this.Sprite.SpriteEffects = SpriteEffects.None;
                }
            }

            if ((Pos.X < 128+96 && Game1.last) || (Pos.X > 1024-128-96 && !Game1.last))
            {
                Game1.score++;
                Game1.last = !Game1.last;
                SoundHandler.PlaySound(SoundID.SCORE);
                Console.Out.WriteLine("Score! " + Game1.score);
            }
        }
    }
}
