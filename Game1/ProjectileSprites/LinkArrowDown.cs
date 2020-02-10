using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Game1.PlayerStates;

namespace Game1.PlayerSprites
{
    class LinkArrowDown : ISprite
    {
        Texture2D texture;
        IPlayer player;
        int linkSrcWidth = 15;
        int linkSrcHeight = 16;
        int arrowSrcWidth = 12;
        int arrowSrcHeight = 16;
        int linkDestWidth = 15;
        int linkDestHeight = 16;
        int arrowDestWidth = 12;
        int arrowDestHeight = 16;
        int linkSrcX = 0; /*Change this*/
        int linkSrcY = 60;  /*and this*/
        int arrowSrcX = 125;
        int arrowSrcY = 195;
        int arrowOffset = 11;
        int curFrame = 1;
        int totalFrames = 5; /*Maybe this*/
        int delay = 0;
        int coolDown = 20;

        public LinkArrowDown(IPlayer player, Texture2D texture)
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
                    player.SetState(new PStateIdleDown(player,coolDown));
                }
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle linkDestRec = new Rectangle((int)player.GetPosition().X, (int)player.GetPosition().Y, linkDestWidth, linkDestHeight);
            Rectangle linkSrcRec = new Rectangle(linkSrcX, linkSrcY, linkSrcWidth, linkSrcHeight);
            Rectangle arrowSrcRec = new Rectangle(arrowSrcX, arrowSrcY, arrowSrcWidth, arrowSrcHeight);
            Rectangle arrowDestRec;
           
                arrowDestRec = new Rectangle((int)player.GetPosition().X, (int)player.GetPosition().Y + arrowOffset+curFrame*50, arrowDestWidth, arrowDestHeight);
           
           
            spriteBatch.Begin();
            spriteBatch.Draw(texture, arrowDestRec, arrowSrcRec, Color.White);
            spriteBatch.Draw(texture, linkDestRec, linkSrcRec, Color.White);
            spriteBatch.End();
        }
    }
}
