using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class SpriteFactoryItems
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

        public ISprite getArrow(IItems item)
        {
            return new ArrowSprite(item,linkSheet);
        }
        /*
        public ISprite getBomb()
        {
            return new BombSprite(bombSheet);
        }
        */
       /* public ISprite getBoomerange()
        {
            return new BoomerangSprite(boomerangSheet);
        }*/

       /* public ISprite getClock()
        {
            return new ClockSprite(clockSheet);
        }*/

        /*public ISprite getHeart()
        {
            return new HeartSprite(heartSheet);
        }*/

        /*public ISprite getKey()
        {
            return new KeySprite(keySheet);
        }*/

       /* public ISprite getRupee()
        {
            return new RupeeSprite(rupeeSheet);
        }*/

        /*public ISprite getSword()
        {
            return new SwordSprite(swordSheet);
        }*/

    }
}
