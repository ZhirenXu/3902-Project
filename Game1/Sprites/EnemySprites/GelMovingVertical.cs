using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.EnemySprites
{
    class GelMovingVertical :ISprite
    {
        Texture2D texture;
        IEnemy enemy;
        private int backgroundHeight = 176;
        private int bottomY = 144;
        private float backgroundVerticalRatio;
        private int srcWidth = 8;
        private int srcHeight = 16;
        private int destWidth = 8;
        private int destHeight = 16;
        private int spriteX;
        private int spriteY;
        private int srcX = 90; /*Change this*/
        private int srcY = 0;  /*and this*/
        private int curFrame = 1;
        private int totalFrames = 2; /*Maybe this*/
        private int delay = 0;
        private int moveSpeed;
        private int minY;
        private int maxY;

        public GelMovingVertical(IEnemy enemy, Texture2D texture)
        {
            backgroundVerticalRatio = (int)enemy.GetBoundary().Y / backgroundHeight;
            this.texture = texture;
            this.enemy = enemy;
            moveSpeed = enemy.Speed;
            destWidth *= enemy.Size;
            destHeight *= enemy.Size;
            minY = (int)(33 * backgroundVerticalRatio);
            maxY = (int)(33 * backgroundVerticalRatio + bottomY * backgroundVerticalRatio);
        }
        public void calcPosition()
        {
            spriteX = (int)enemy.GetPosition().X;
            spriteY = (int)enemy.GetPosition().Y + moveSpeed;
            if (spriteY < minY || spriteY > maxY)
            {
                moveSpeed = moveSpeed * -1;
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
            enemy.SetPosition(spriteX, spriteY); /*Change this*/
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle destRec = new Rectangle((int)enemy.GetPosition().X, (int)enemy.GetPosition().Y, destWidth, destHeight);
            Rectangle srcRec;
            if (curFrame == 1) /*Change these to correct frames, might need to add/delete else if*/
            {
                srcX = 1;
                srcY = 11;
            }
            else if (curFrame == 2)
            {
                srcX = 10;
                srcY = 11;
            }
            srcRec = new Rectangle(srcX, srcY, srcWidth, srcHeight);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destRec, srcRec, Color.White);
            spriteBatch.End();
        }
    }
}
