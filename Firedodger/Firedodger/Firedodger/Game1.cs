using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Firedodger.Graphics;
using Firedodger.Engine;
using Firedodger.Handlers;

namespace Firedodger
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        List<GameObject> gameObjects = new List<GameObject>();
        public static int score = 0;
        public static Boolean last = false;
        private Matrix wubMatrix;
        private Matrix projectionMatrix;
        private float wubitude = 0.0f;
        private float wubness = 0.5f;
        public static double songTime = 0;
        private int currentWub = 0;
        private int curWubInc = 0;
        private static double[] wubs = new double[]{ 27.621, 30.154, 30.962, 33.516, 34.399, 37.046, 37.873, 40.483, 41.272, 43.732, 44.689, 47.301, 48.126, 50.737, 51.601, 54.119, 54.962, 56.709, 58.381, 60.089, 61.854, 62.624, 63.508, 64.446, 65.31, 65.723, 66.099, 66.53, 68.784, 72.108, 75.527, 78.945, 80.541, 80.803, 81.048, 81.33, 81.574, 82.456, 85.817, 89.272, 92.709, 93.572, 94.211, 94.512, 94.737, 94.981, 95.244, 96.259, 96.521, 96.803, 97.028, 97.497, 97.911, 98.361, 98.587, 98.793, 99.224, 99.356, 99.469, 99.601, 99.862, 100.144, 100.37, 100.896, 101.289, 101.553, 102.135, 103.017, 103.337, 103.656, 103.863, 104.331, 106.004, 106.153, 106.284, 106.417, 106.736, 107.055, 108.201, 108.633, 109.027, 109.89, 110.247, 110.492, 110.735, 111.938, 112.201, 112.426, 112.914, 113.121, 113.328, 113.59, 113.947, 114.153, 114.605, 114.999, 115.243, 115.863, 116.351, 116.783, 117.027, 117.327, 117.552, 118.021, 118.791, 119.035, 119.317, 119.768, 119.9, 120.032, 120.144, 120.462, 120.743, 120.988, 121.477, 121.834, 122.696, 123.167, 123.561, 124.425, 125.344, 126.133, 127.016, 127.899, 128.763, 129.626, 130.453, 131.299, 132.144, 133.006, 133.87, 134.735, 135.541, 136.462, 137.306, 137.683, 138.097, 138.566, 138.772, 139.016, 139.466, 139.861, 140.293, 140.499, 140.724, 140.912, 141.156, 141.344, 141.551, 142.021, 142.226, 142.433, 142.621, 142.846, 143.034, 143.298, 143.71, 143.916, 144.161, 144.368, 144.592, 144.761, 145.005, 145.437, 145.831, 146.227, 146.432, 146.639, 146.845, 147.352, 147.615, 148.028, 148.441, 148.854, 149.268, 149.456, 149.681, 150.113, 150.32, 150.995, 151.295, 151.464, 151.653, 151.86, 152.273, 152.686, 153.099, 153.53, 153.98, 154.412, 154.601, 154.787, 155.013, 155.238, 155.671, 156.064, 156.497, 156.966, 157.454, 157.869, 158.037, 158.262, 158.487, 158.75, 159.144, 159.576, 160.028, 160.479, 160.872, 161.341, 161.529, 161.698, 161.905, 162.13, 162.581, 162.863, 163.2, 163.518, 163.801, 164.703, 164.966, 165.247, 165.416, 165.604, 166.017, 167.22, 168.046, 168.271, 168.496, 168.721, 169.004, 169.379, 170.637, 171.52, 171.726, 171.952, 172.177, 172.421, 172.834, 174.073, 174.956, 175.163, 175.388, 175.613, 175.839, 176.308, 176.57, 176.909, 177.209, 177.473, 178.524, 178.806, 179.068, 179.313, 179.744, 180.383, 180.495, 180.628, 180.871, 181.059, 181.491, 181.604, 181.735, 181.847, 182.167, 182.486, 182.674, 183.181, 183.781, 183.914, 184.044, 184.496, 184.928, 185.284, 185.603, 185.904, 186.111, 186.58, 187.255, 187.386, 187.5, 187.744, 187.95, 188.326, 188.439, 188.57, 188.702, 189.02, 189.302, 189.564, 190.279, 190.448, 190.598, 190.823, 191.31, 191.743, 192.138, 192.476, 192.795, 193.039, 194.128, 194.222, 194.335, 194.56, 194.729, 195.199, 195.311, 195.461, 195.592, 195.875, 196.176, 196.4, 196.739, 196.87, 197.546, 197.678, 197.789, 198.146, 198.353, 198.56, 198.992, 199.329, 199.648, 199.855, 200.155, 200.288, 200.381, 200.981, 201.075, 201.207, 201.452, 201.601, 202.014, 202.146, 202.296, 202.408, 202.728, 203.067, 203.311, 203.761, 204.024, 204.193, 204.531, 204.868, 205.056, 205.431, 205.864, 206.258, 206.464, 206.671, 207.141, 207.366, 207.61, 207.816, 208.041, 208.437, 208.85, 209.056, 209.282, 209.714, 209.921, 210.145, 210.596, 211.065, 211.291, 211.478, 211.911, 212.322, 212.737, 213.15, 213.375, 213.582, 214.013, 214.428, 214.821, 215.027, 215.214, 215.478, 215.722, 215.93, 216.154, 216.568, 217, 217.188, 217.375, 217.6, 217.826, 218.033, 218.258, 218.465, 218.689, 218.914, 219.384, 219.571, 219.986, 220.398, 220.905, 221.093, 221.318, 221.713, 222.145, 222.595, 222.802, 223.008, 223.234, 223.439, 223.665, 223.872, 224.304, 224.529, 224.736, 224.923, 225.149, 225.335, 225.562, 226.03, 226.219, 226.424, 226.631, 226.838, 227.026, 227.271, 227.721, 228.134, 228.529, 228.735, 228.96, 229.261, 229.28, 229.694, 229.899, 230.332, 230.688, 231.12, 231.552, 231.796, 231.983, 232.49, 232.698, 233.299 };
        private static double[] wubIncrease = new double[] { 41, 55, 66, 67, 68 };
        private SpriteFont font;
        private Texture2D scorewindow;
        private Texture2D goTo;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            graphics.PreferredBackBufferWidth = Options.WindowWidth;
            graphics.PreferredBackBufferHeight = Options.WindowHeight;
            graphics.IsFullScreen = Options.Fullscreen;
            graphics.ApplyChanges();

            projectionMatrix = Matrix.CreateOrthographicOffCenter(0.0f, (float)GraphicsDevice.Viewport.Width, (float)GraphicsDevice.Viewport.Height, 0.0f, 0.0f, 1.0f);

            wubMatrix = Matrix.Identity;

            GraphicHandler.Initialize();
            GameObjectHandler.Initialize();
            SoundHandler.Initialize();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            GraphicHandler.LoadContent(Content);
            SoundHandler.LoadContent(Content);
            font = Content.Load<SpriteFont>("Graphics/DefaultFont");
            scorewindow = Content.Load<Texture2D>("Graphics/Sprites/Objects/scorebar");
            goTo = Content.Load<Texture2D>("Graphics/Sprites/Objects/star");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            GameObjectHandler.Update(gameTime);
            SoundHandler.Update(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            base.Draw(gameTime);
            wubMatrix *= Matrix.CreateTranslation(-(float)(GraphicsDevice.Viewport.Width / 2), -(float)(GraphicsDevice.Viewport.Height / 2), 0);

            wubMatrix *= Matrix.CreateFromYawPitchRoll(0, 0, wubitude);
            wubMatrix *= Matrix.CreateTranslation((float)(GraphicsDevice.Viewport.Width / 2), (float)(GraphicsDevice.Viewport.Height / 2), 0);

            if (songTime < wubs[0])
            {
                curWubInc = 0;
                currentWub = 0;
            }

            if (curWubInc < wubIncrease.Length && songTime >= wubIncrease[curWubInc])
            {
                wubness *= 3f;
                curWubInc++;
            }

            if (currentWub < wubs.Length && songTime >= wubs[currentWub])
            {
                wubness *= -1;
                wubitude = (float)((float)GameObjectHandler.random.Next(1,10) * wubness * 0.0001);
                currentWub++;
            }

            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.LinearClamp, DepthStencilState.Default, RasterizerState.CullNone, null, wubMatrix);
            GameObjectHandler.Draw(spriteBatch);
            spriteBatch.End();
            spriteBatch.Begin();
            spriteBatch.Draw(scorewindow,new Vector2(10f,10f),Color.White);
            spriteBatch.DrawString(font, "Score: " + score, new Vector2(32, 24), Color.White);
            Color goColor = Color.Red;
            if(last)
            {
                goColor = Color.Blue;
            }
            spriteBatch.Draw(goTo, new Vector2(512 - 128, 128), goColor);
            spriteBatch.End();
        }
    }
}
