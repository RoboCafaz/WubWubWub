using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firedodger.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Firedodger.Constants;
using Firedodger.Engine.GameObjects;

namespace Firedodger.Handlers
{
    class GameObjectHandler
    {
        private static List<GameObject> gameObjects = new List<GameObject>();
        public static Random random = new Random();

        public static void Add(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
        }

        public static GameObject Get(int id)
        {
            return gameObjects.ElementAt(id);
        }

        public static void Initialize()
        {
            Add(new Backdrop(SpriteID.BG_LAKE, new Vector2(-1024 / 4, -768 / 2), 1));
            Add(new ControllableObject(SpriteID.OUR_HERO, new Vector2(256, 668 - 32 - 64), 0.25, PlayerIndex.One));
            Add(new GameObject(SpriteID.RED_FLAG, new Vector2(1024-96-128, 668-320), 1));
            Add(new GameObject(SpriteID.BLUE_FLAG, new Vector2(128, 668 - 320), 1));
            Add(new Backdrop(SpriteID.GENERIC_TILE, new Vector2(-256, 668 - 32), 1));
            Add(new GameObject(SpriteID.GENERIC_TILE, new Vector2(0, 668 - 32), 1));
            Add(new GameObject(SpriteID.GENERIC_TILE, new Vector2(256, 668 - 32), 1));
            Add(new GameObject(SpriteID.GENERIC_TILE, new Vector2(512, 668 - 32), 1));
            Add(new GameObject(SpriteID.GENERIC_TILE, new Vector2(768, 668 - 32), 1));
            Add(new GameObject(SpriteID.GENERIC_TILE, new Vector2(768 + 256, 668 - 32), 1));
            Add(new Inferno(SpriteID.BG_INFERNO, new Vector2(-1024, 768), 1));
            Add(new Inferno(SpriteID.BG_INFERNO, new Vector2(0, 768), 1));
            Add(new Inferno(SpriteID.BG_INFERNO, new Vector2(1024, 768), 1));
            Add(new Dragon(SpriteID.DARGON, new Vector2(-512, 240), 0.25));

            foreach (GameObject g in gameObjects)
            {
                g.Initialize();
            }
        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            foreach (GameObject g in gameObjects)
            {
                g.Draw(spriteBatch);
            }
        }

        private static int lastFireball = 0;

        public static void Update(GameTime gameTime)
        {
            if (lastFireball > 1000 / ((Game1.score+1)*1.8))
            {
                Fireball newFire = new Fireball(SpriteID.FIREBALL, new Vector2(random.Next(128+96, 1024 - 128 - 96), -128), 0.7, (int)Math.Ceiling((double)(Game1.score+1)/3));
                newFire.Initialize();
                Add(newFire);
                lastFireball = 0;
            }
            else
            {
                lastFireball++;
            }
            foreach (GameObject g in gameObjects)
            {
                g.Update(gameTime);
            }
            gameObjects.RemoveAll(KillIt);
        }

        private static bool KillIt(GameObject g)
        {
            if (g.KillMe)
            {
                if (g.SpriteId.Equals(SpriteID.FIREBALL))
                {
                    for (int i = 0; i < random.Next(100, 1000); i++)
                    {
                        Particle magical = new Particle(SpriteID.P_FIRE, g.Pos, 0.1, random.Next(3,6), random.NextDouble()*7, random.Next(250,500), true);
                        magical.Initialize();
                        GameObjectHandler.Add(magical);
                    }
                }
                return true;
            }
            else if (g.SpriteId.Equals(SpriteID.FIREBALL) && g.Pos.Y > 768)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
