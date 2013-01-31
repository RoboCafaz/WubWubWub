using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firedodger.Constants;
using Microsoft.Xna.Framework;

namespace Firedodger.Engine.GameObjects
{
    class Particle : GameObject
    {
        private Vector2 _direction;
        private int _speed;
        private double _spawnTime = -1;
        private double _timeOut;
        private Boolean _fade;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="spriteId">ID number of the particle's sprite.</param>
        /// <param name="pos">Origin position of the particle.</param>
        /// <param name="scale">Scale of the particle.</param>
        /// <param name="speed">Speed at which the particle travels.</param>
        /// <param name="direction">Direction in which the particle travels.</param>
        /// <param name="timeOut"></param>
        public Particle(SpriteID spriteId, Vector2 pos, double scale, int speed, double direction, double timeOut)
            : base(spriteId, pos, scale)
        {
            this._speed = speed;
            this._direction = new Vector2((float)Math.Cos(direction), (float)Math.Sin(direction));
            this._timeOut = timeOut;
        }

        public Particle(SpriteID spriteId, Vector2 pos, double scale, int speed, double direction, double timeOut, Boolean fade)
            : this(spriteId, pos, scale, speed, direction, timeOut)
        {
            this._fade = fade;
        }

        public override void Update(GameTime gameTime)
        {
            if (this._spawnTime <= 0)
            {
                this._spawnTime = gameTime.TotalGameTime.TotalMilliseconds;
            }
            base.Update(gameTime);
            if (gameTime.TotalGameTime.TotalMilliseconds - _spawnTime >= _timeOut)
            {
                this.Destroy();
            }
            else
            {
                this.Pos += _direction * _speed;
                if (_fade)
                {
                    this.Sprite.Color = new Color(this.Sprite.Color.R, this.Sprite.Color.G, this.Sprite.Color.B, (float)(this.Sprite.Color.A * ((gameTime.TotalGameTime.TotalMilliseconds - _spawnTime) / _timeOut)));
                }
            }
        }
    }
}
