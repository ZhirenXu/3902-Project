using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.PlayerSprites
{
    class LinkStabbingRight :ISprite
    {
        Texture2D texture;
        IPlayer player;
        int srcWidth = 15;
        int srcHeight = 16;
        int destWidth = 15;
        int destHeight = 16;
        int srcX = 30; /*Change this*/
        int srcY = 60;  /*and this*/
        int curFrame = 1;
        int totalFrames = 2; /*Maybe this*/
        int delay = 0;     

        public LinkStabbingRight(IPlayer player, Texture2D texture)
        {
            this.texture = texture;
            this.player = player;
            this.destWidth *= player.Size;
            this.destHeight *= player.Size;
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
            player.SetPosition((int)player.GetPosition().X, (int)player.GetPosition().Y); /*Change this*/
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle destRec = new Rectangle((int)player.GetPosition().X, (int)player.GetPosition().Y, destWidth, destHeight);
            Rectangle srcRec;
            if (curFrame == 1) /*Change these to correct frames, might need to add/delete else if*/
            {
                srcX = 90;
                srcY = 60;
            }
            else if(curFrame == 2)
            {
                srcX = 90;
                srcY = 90;
            }
            srcRec = new Rectangle(srcX, srcY, srcWidth, srcHeight);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destRec, srcRec, Color.White);
            spriteBatch.End();
        }
    }
}
