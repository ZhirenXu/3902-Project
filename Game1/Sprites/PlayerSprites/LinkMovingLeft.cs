﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.PlayerSprites
{
    class LinkMovingLeft :ISprite
    {
        private Texture2D texture;
        private IPlayer player;
        private int backgroundWidth = 256;
        private int srcWidth = 15;
        private int srcHeight = 16;
        private int destWidth = 15;
        private int destHeight = 16;
        private int srcX = 30; /*Change this*/
        private int srcY = 29;  /*and this*/
        private int spriteX;
        private int spriteY;
        private int curFrame = 1;
        private int totalFrames = 2; /*Maybe this*/
        private int delay = 0;
        private int moveSpeed;
        private float backgroundHorizontalRatio;

        public LinkMovingLeft(IPlayer player, Texture2D texture)
        {
            this.texture = texture;
            this.player = player;
            this.moveSpeed = player.Speed;
            this.destWidth *= player.Size;
            this.destHeight *= player.Size;
            this.backgroundHorizontalRatio = (int)player.GetBoundary().X / backgroundWidth;
        }
        public void calcPosition()
        {
            spriteX = (int)player.GetPosition().X - moveSpeed;
            spriteY = (int)player.GetPosition().Y;
            if(spriteX < (290 * backgroundHorizontalRatio - 257 * backgroundHorizontalRatio))
            {
                spriteX = (int)(290 * backgroundHorizontalRatio - 257 * backgroundHorizontalRatio);
            }
        }
        public void Update()
        {
            delay++;
            if(delay == 7) /*Delay of frame changes*/
            {
                delay = 0;
                curFrame++;
                if(curFrame > totalFrames)
                {
                    curFrame = 1;
                }
            }
            calcPosition();
            player.SetPosition(spriteX, spriteY); /*Change this*/
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle destRec = new Rectangle((int)player.GetPosition().X, (int)player.GetPosition().Y, destWidth, destHeight);
            Rectangle srcRec;
            if (curFrame == 1) /*Change these to correct frames, might need to add/delete else if*/
            {
                srcX = 30;
                srcY = 29;
            }
            else if(curFrame == 2)
            {
                srcX = 30;
                srcY = 0;
            }
            srcRec = new Rectangle(srcX, srcY, srcWidth, srcHeight);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destRec, srcRec, Color.White);
            spriteBatch.End();
        }
    }
}
