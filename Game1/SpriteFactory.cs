using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Game1.PlayerSprites;
using Game1.ProjectileSprites;

namespace Game1
{
    class SpriteFactory
    {
        private Texture2D linkSheet;
        private static SpriteFactory instance = new SpriteFactory();
        public static SpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }
        private SpriteFactory()
        {
        }

        public void LoadAll(ContentManager content)
        {
            linkSheet = content.Load<Texture2D>("ProjectSpriteSheets/LinkSpriteSheet");
        }

        public ISprite GetLinkIdleDown(IPlayer player)
        {
            return new LinkIdleDown(player,linkSheet);
        }

        public ISprite GetLinkIdleUp(IPlayer player)
        {
            return new LinkIdleUp(player, linkSheet);
        }

        public ISprite GetLinkIdleRight(IPlayer player)
        {
            return new LinkIdleRight(player, linkSheet);
        }

        public ISprite GetLinkIdleLeft(IPlayer player)
        {
            return new LinkIdleLeft(player, linkSheet);
        }

        public ISprite GetLinkMovingDown(IPlayer player)
        {
            return new LinkMovingDown(player, linkSheet);
        }

        public ISprite GetLinkMovingUp(IPlayer player)
        {
            return new LinkMovingUp(player, linkSheet);
        }

        public ISprite GetLinkMovingRight(IPlayer player)
        {
            return new LinkMovingRight(player, linkSheet);
        }

        public ISprite GetLinkMovingLeft(IPlayer player)
        {
            return new LinkMovingLeft(player, linkSheet);
        }

        public ISprite GetLinkStabbingUp(IPlayer player)
        {
            return new LinkStabbingUp(player, linkSheet);
        }

        public ISprite GetLinkStabbingDown(IPlayer player)
        {
            return new LinkStabbingDown(player, linkSheet);
        }

        public ISprite GetLinkStabbingLeft(IPlayer player)
        {
            return new LinkStabbingLeft(player, linkSheet);
        }

        public ISprite GetLinkStabbingRight(IPlayer player)
        {
            return new LinkStabbingRight(player, linkSheet);
        }
        public ISprite GetLinkShootingDown(IPlayer player, System.Type type)
        {
            return new LinkShootingDown(player, linkSheet, type);
        }
        public ISprite GetLinkArrowDown(IProjectile projectile)
        {
            return new ArrowDown(projectile, linkSheet);
        }
        public ISprite GetLinkArrowUp(IPlayer player)
        {
            return new LinkArrowUp(player, linkSheet);
        }
        public ISprite GetLinkArrowLeft(IPlayer player)
        {
            return new LinkArrowLeft(player, linkSheet);
        }
        public ISprite GetLinkArrowRight(IPlayer player)
        {
            return new LinkArrowRight(player, linkSheet);
        }
        public ISprite GetLinkDamagedUp(IPlayer player)
        {
            return new LinkDamagedUp(player, linkSheet);
        }
        public ISprite GetLinkDamagedDown(IPlayer player)
        {
            return new LinkDamagedDown(player, linkSheet);
        }
        public ISprite GetLinkDamagedRight(IPlayer player)
        {
            return new LinkDamagedRight(player, linkSheet);
        }
        public ISprite GetLinkDamagedLeft(IPlayer player)
        {
            return new LinkDamagedLeft(player, linkSheet);
        }
    }
}
