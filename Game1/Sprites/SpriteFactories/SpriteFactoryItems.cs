using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Sprites.SpriteFactories
{
    public class SpriteFactoryItems
    {
        private Texture2D arrowSheet;
        private Texture2D bombSheet;
        private Texture2D boomerangeSheet;
        private Texture2D clockSheet;
        private Texture2D heartSheet;
        private Texture2D keySheet;
        private Texture2D rupeeSheet;
        private Texture2D swordSheet;

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
            arrowSheet = content.Load<Texture2D>("items/Arrow");
            bombSheet = content.Load<Texture2D>("items/Bomb");
            bommerangeSheet = content.Load<Texture2D>("items/Boomerang");
            clockSheet = content.Load<Texture2D>("items/Clock");
            heartSheet = content.Load<Texture2D>("items/Heart");
            keySheet = content.Load<Texture2D>("items/Key");
            rupeeSheet = content.Load<Texture2D>("items/Rupee");
            swordSheet = content.Load<Texture2D>("items/Sword");

        }

        public ISprite getArrow()
        {
            return new ArrowSprite(arrowSheet);
        }

        public ISprite getBomb()
        {
            return new BombSprite(bombSheet);
        }

        public ISprite getBoomerange()
        {
            return new BoomerangSprite(boomerangSheet);
        }

        public ISprite getClock()
        {
            return new ClockSprite(clockSheet);
        }

        public ISprite getHeart()
        {
            return new HeartSprite(heartSheet);
        }

        public ISprite getKey()
        {
            return new KeySprite(keySheet);
        }

        public ISprite getRupee()
        {
            return new RupeeSprite(rupeeSheet);
        }

        public ISprite getSword()
        {
            return new SwordSprite(swordSheet);
        }

    }
}
