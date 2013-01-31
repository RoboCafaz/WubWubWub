using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Firedodger.Constants;

namespace Firedodger.Graphics
{
    class Sprite
    {
        protected SpriteID _id;
        protected String _name;
        protected Texture2D _graphic;
        protected String _textureFileName;
        protected Vector2 _dimensions;
        protected Boolean _loaded;
        protected Vector2 _frameDimensions;
        protected int _frames;
        protected int _animations;
        protected int _fps;
        protected int _currentFrame = 0;
        protected int _currentAnimation = 0;
        protected int _sinceUpdate = 0;
        private SpriteEffects _spriteEffects;
        protected Color _color;

        public Sprite(SpriteID id, String name, String textureFileName)
            : this(id, name, textureFileName, new Vector2(0, 0), 0)
        {
        }

        public Sprite(SpriteID id, String name, String textureFileName, Vector2 frameDimensions, int fps)
        {
            this._id = id;
            this._name = name;
            this._textureFileName = textureFileName;
            this._loaded = false;
            this._frameDimensions = frameDimensions;
            this._fps = fps;
            this._color = Color.White;
        }

        public void Update(GameTime gameTime)
        {
            if (_fps > 0)
            {
                _sinceUpdate++;
                if (_sinceUpdate >= (60 / _fps))
                {
                    _sinceUpdate = 0;
                    _currentFrame++;
                    if (_currentFrame >= _frames)
                    {
                        _currentFrame = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Draws the sprite in its current state.
        /// </summary>
        /// <param name="spriteBatch">spriteBatch object</param>
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        /// <param name="w">width to draw sprite</param>
        /// <param name="h">height to draw sprite</param>
        public void Draw(SpriteBatch spriteBatch, int x, int y, int w, int h)
        {
            spriteBatch.Draw(_graphic, new Rectangle(x, y, w, h), new Rectangle((int)this._frameDimensions.X * _currentFrame, (int)this._frameDimensions.Y * _currentAnimation, (int)this._frameDimensions.X, (int)this._frameDimensions.Y), _color, 0, new Vector2(0, 0), _spriteEffects, 0);
        }

        /// <summary>
        /// Draws the sprite in its current state.
        /// </summary>
        /// <param name="spriteBatch">spriteBatch object</param>
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        public void Draw(SpriteBatch spriteBatch)
        {
            if (_loaded)
            {
                Draw(spriteBatch, 0, 0, (int)_frameDimensions.X, (int)_frameDimensions.Y);
            }
        }

        /// <summary>
        /// Draws the sprite in its current state at 0,0.
        /// </summary>
        /// <param name="spriteBatch">spriteBatch object</param>
        public void Draw(SpriteBatch spriteBatch, int x, int y)
        {
            Draw(spriteBatch, x, y, (int)_frameDimensions.X, (int)_frameDimensions.Y);
        }

        public void LoadContent(ContentManager Content)
        {
            _graphic = Content.Load<Texture2D>(_textureFileName);
            _dimensions = new Vector2(_graphic.Width, _graphic.Height);
            _frames = (int)(_dimensions.X / _frameDimensions.X);
            _animations = (int)(_dimensions.Y / _frameDimensions.Y);
            if (_frameDimensions.X == 0 || _frameDimensions.Y == 0)
            {
                _frameDimensions = _dimensions;
            }
            this._loaded = true;
        }

        public SpriteID id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Vector2 Dimensions
        {
            get { return _dimensions; }
            set { _dimensions = value; }
        }

        public Vector2 FrameDimensions
        {
            get { return _frameDimensions; }
            set { _frameDimensions = value; }
        }

        public int Frames
        {
            get { return _frames; }
            set { _frames = value; }
        }

        public int Animations
        {
            get { return _animations; }
            set { _animations = value; }
        }

        public int FPS
        {
            get { return _fps; }
            set { _fps = value; }
        }

        public int CurrentFrame
        {
            get { return _currentFrame; }
            set { _currentFrame = value; }
        }

        public int CurrentAnimation
        {
            get { return _currentAnimation; }
            set { _currentAnimation = value; }
        }

        public int SinceUpdate
        {
            get { return _sinceUpdate; }
            set { _sinceUpdate = value; }
        }

        public SpriteEffects SpriteEffects
        {
            get { return _spriteEffects; }
            set { _spriteEffects = value; }
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }
}
