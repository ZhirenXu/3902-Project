using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Game1.PlayerStates;
using System;

namespace Game1.ProjectileSprites
{
    class BombDown : ISprite
    {
        private Texture2D texture;
        private IProjectile projectile;
        private int srcWidth = 12;
        private int srcHeight = 15;
        private int destWidth = 12;
        private int destHeight = 15;
        private int srcX = 360;
        private int srcY = 225;
        private int timer;

        public BombDown(IProjectile projectile, Texture2D texture)
        {
            this.texture = texture;
            this.projectile = projectile;
            this.destWidth *= projectile.Size;
            this.destHeight *= projectile.Size;
            this.timer = 20;
        }
        public void Update()
        {
            timer--;
            if(timer == 0)
            {
                projectile.Explode();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle arrowSrcRec = new Rectangle(srcX, srcY, srcWidth, srcHeight);
            Rectangle arrowDestRec = new Rectangle((int)projectile.GetPosition().X, (int)projectile.GetPosition().Y+15*projectile.Size, destWidth, destHeight);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, arrowDestRec, arrowSrcRec, Color.White);
            spriteBatch.End();
        }
    }
}
