﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.EnemySprites
{
    class GelMovingRight :ISprite
    {
        Texture2D texture;
        IPlayer player;
        int srcWidth = 15;
        int srcHeight = 16;
        int destWidth = 15;
        int destHeight = 16;
        int spriteX;
        int spriteY;
        int BoundaryX;
        int srcX = 90; /*Change this*/
        int srcY = 0;  /*and this*/
        int curFrame = 1;
        int totalFrames = 2; /*Maybe this*/
        int delay = 0;     
        int moveSpeed;

        public GelMovingRight(IPlayer player, Texture2D texture)
        {
            this.texture = texture;
            this.player = player;
            this.moveSpeed = player.Speed;
            this.destWidth *= player.Size;
            this.destHeight *= player.Size;
        }
        public void calcPosition()
        {
            spriteX = (int)player.GetPosition().X + moveSpeed;
            spriteY = (int)player.GetPosition().Y;
            BoundaryX = (int)player.GetBoundary().X - destWidth;
            if (spriteX > BoundaryX)
            {
                spriteX = BoundaryX;
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
                srcX = 90;
                srcY = 0;
            }
            else if(curFrame == 2)
            {
                srcX = 90;
                srcY = 30;
            }
            srcRec = new Rectangle(srcX, srcY, srcWidth, srcHeight);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destRec, srcRec, Color.White);
            spriteBatch.End();
        }
    }
}
