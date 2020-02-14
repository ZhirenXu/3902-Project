using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Game1.PlayerStates;

namespace Game1.PlayerSprites
{
    class LinkArrowLeft : ISprite
    {
        Texture2D texture;
        IPlayer player;
        int linkSrcWidth = 15;
        int linkSrcHeight = 16;
        int arrowSrcWidth = 18;
        int arrowSrcHeight = 12;
        int linkDestWidth = 15;
        int linkDestHeight = 16;
        int arrowDestWidth = 16;
        int arrowDestHeight = 12;
        int linkSrcX = 30; /*Change this*/
        int linkSrcY = 60;  /*and this*/
        int arrowSrcX = 150;
        int arrowSrcY = 194;
        int arrowOffset = 12;
        int curFrame = 1;
        int totalFrames = 5; /*Maybe this*/
        int delay = 0;
        int coolDown = 20;

        public LinkArrowLeft(IPlayer player, Texture2D texture)
        {
            this.texture = texture;
            this.player = player;
            this.linkDestWidth *= player.Size;
            this.linkDestHeight *= player.Size;
            this.arrowDestWidth *= player.Size;
            this.arrowDestHeight *= player.Size;
            this.arrowOffset *= player.Size;
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
                    player.SetState(new PStateIdleLeft(player, coolDown));
                }
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle linkDestRec = new Rectangle((int)player.GetPosition().X, (int)player.GetPosition().Y, linkDestWidth, linkDestHeight);
            Rectangle linkSrcRec = new Rectangle(linkSrcX, linkSrcY, linkSrcWidth, linkSrcHeight);
            Rectangle arrowSrcRec = new Rectangle(arrowSrcX, arrowSrcY, arrowSrcWidth, arrowSrcHeight);
            Rectangle arrowDestRec;
           
                arrowDestRec = new Rectangle((int)player.GetPosition().X - curFrame*50, (int)player.GetPosition().Y, arrowDestWidth, arrowDestHeight);
            
            spriteBatch.Begin();
            spriteBatch.Draw(texture, arrowDestRec, arrowSrcRec, Color.White);
            spriteBatch.Draw(texture, linkDestRec, linkSrcRec, Color.White);
            spriteBatch.End();
        }
    }
}