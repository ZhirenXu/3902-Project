using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Game1.PlayerSprites;
using Game1.EnemySprites;
using Game1.ProjectileSprites;
using System;

namespace Game1.ItemSprites
{
    class SpriteFactoryItems
    {
        private Texture2D linkSheet;
        private static SpriteFactoryItems instance = new SpriteFactoryItems();
        public static SpriteFactoryItems Instance
        {
            get
            {
                return instance;
            }
        }

        private SpriteFactoryItems()
        {
        }

        public void LoadAll(ContentManager content)
        {
            linkSheet = content.Load<Texture2D>("ProjectSpriteSheets/LinkSpriteSheet");

        }

        public ISprite GetArrowSprite(IItem item)
        {
            return new ArrowSprite(item,linkSheet);
        }

    }
}