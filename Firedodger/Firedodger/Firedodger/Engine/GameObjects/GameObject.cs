using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Firedodger.Graphics;
using Firedodger.Handlers;
using Firedodger.Constants;

namespace Firedodger.Engine
{
    class GameObject
    {
        private SpriteID _spriteId;
        private Sprite _sprite;
        private Vector2 _pos;
        private double _scale;
        private Rectangle _bounding;
        private Boolean _killMe = false;

        public GameObject(SpriteID spriteId, Vector2 pos, double scale)
        {
            this._spriteId = spriteId;
            this._pos = pos;
            this._scale = scale;
        }

        public GameObject(SpriteID spriteId)
            : this(spriteId, new Vector2(0, 0), 1.0f)
        {
        }

        public virtual void Update(GameTime gameTime)
        {
            _sprite.Update(gameTime);
            _bounding = new Rectangle((int)_pos.X, (int)_pos.Y, (int)(_sprite.FrameDimensions.X * _scale), (int)(_sprite.FrameDimensions.Y * _scale));
        }

        public void Initialize()
        {
            _sprite = GraphicHandler.Get(_spriteId);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            _sprite.Draw(spriteBatch, (int)_pos.X, (int)_pos.Y, (int)(_sprite.FrameDimensions.X * _scale), (int)(_sprite.FrameDimensions.Y * _scale));
        }

        public void Destroy()
        {
            _killMe = true;
        }

        public SpriteID SpriteId
        {
            get { return _spriteId; }
            set { _spriteId = value; }
        }

        public Sprite Sprite
        {
            get { return _sprite; }
            set { _sprite = value; }
        }

        public Vector2 Pos
        {
            get { return _pos; }
            set { _pos = value; }
        }

        public double Scale
        {
            get { return _scale; }
            set { _scale = value; }
        }

        public Rectangle Bounding
        {
            get { return _bounding; }
            set { _bounding = value; }
        }

        public Boolean KillMe
        {
            get { return _killMe; }
            set { _killMe = value; }
        }
    }
}
