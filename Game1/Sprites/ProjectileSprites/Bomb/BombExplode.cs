using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Game1.PlayerStates;
using System;

namespace Game1.ProjectileSprites
{
    class BombExplode : ISprite
    {
        private Texture2D texture;
        private IProjectile projectile;
        private int srcWidth = 60;
        private int srcHeight = 55;
        private int destWidth = 60;
        private int destHeight = 55;
        private int srcX = 50;
        private int srcY = 60;
        private int curFrame = 1;
        private int totalFrames = 3; /*Maybe this*/
        private int delay = 0;

        public BombExplode(IProjectile projectile, Texture2D texture)
        {
            this.texture = texture;
            this.projectile = projectile;
            this.destWidth /= projectile.Size;
            this.destHeight /= projectile.Size;
        }
        public void Update()
        {
            delay++;
            if (delay == 3) /*Delay of frame changes*/
            {
                delay = 0;
                curFrame++;
                if (curFrame > totalFrames)
                {
                    curFrame = 1;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (curFrame == 1)
            {

            }
            Rectangle arrowSrcRec = new Rectangle(srcX, srcY, srcWidth, srcHeight);
            Rectangle arrowDestRec = new Rectangle((int)projectile.GetPosition().X, (int)projectile.GetPosition().Y+15*projectile.Size, destWidth, destHeight);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, arrowDestRec, arrowSrcRec, Color.White);
            spriteBatch.End();
        }
    }
}
