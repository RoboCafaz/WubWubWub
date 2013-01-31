using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firedodger.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Firedodger.Constants;

namespace Firedodger.Handlers
{
    class GraphicHandler
    {
        private static List<Sprite> graphics = new List<Sprite>();

        public static void Add(Sprite graphic)
        {
            graphics.Add(graphic);
        }

        public static Sprite Get(SpriteID id)
        {
            foreach (Sprite g in graphics)
            {
                if (g.id.Equals(id))
                {
                    return g;
                }
            }
            return null;
        }

        public static void Initialize()
        {
            Add(new Sprite(SpriteID.BG_LAKE, "Lake Background", "Graphics/Sprites/Backdrops/lake"));
            Add(new Sprite(SpriteID.GENERIC_TILE, "Generic Tile", "Graphics/Sprites/Tiles/tile_generic"));
            Add(new Sprite(SpriteID.BLUE_FLAG, "Blue Flag", "Graphics/Sprites/Items/shitflag_blue"));
            Add(new Sprite(SpriteID.RED_FLAG, "Red Flag", "Graphics/Sprites/Items/shitflag_red"));
            Add(new Sprite(SpriteID.OUR_HERO, "Our hero", "Graphics/Sprites/Mobs/THE HERO", new Vector2(142, 256), 15));
            Add(new Sprite(SpriteID.FIREBALL, "FIYABAWLZ", "Graphics/Sprites/Mobs/fireball", new Vector2(42, 64), 15));
            Add(new Sprite(SpriteID.BG_INFERNO, "INFERNO", "Graphics/Sprites/Backdrops/INFERNO"));
            Add(new Sprite(SpriteID.DARGON, "INFERNO", "Graphics/Sprites/Mobs/dargon"));
            Add(new Sprite(SpriteID.P_FIRE, "PARTICLEZ", "Graphics/Sprites/Mobs/p_fire"));
        }

        public static void LoadContent(ContentManager Content)
        {
            foreach (Sprite g in graphics)
            {
                g.LoadContent(Content);
            }
        }
    }
}
