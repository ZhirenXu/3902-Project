using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Game1.PlayerStates;

namespace Game1.PlayerSprites
{
    class LinkStabbingDown : ISprite
    {
        Texture2D texture;
        IPlayer player;
        int linkSrcWidth = 15;
        int linkSrcHeight = 16;
        int swordSrcWidth = 7;
        int swordSrcHeight = 16;
        int linkDestWidth = 15;
        int linkDestHeight = 16;
        int swordDestWidth = 7;
        int swordDestHeight = 16;
        int linkSrcX = 0; /*Change this*/
        int linkSrcY = 60;  /*and this*/
        int swordSrcX = 4;
        int swordSrcY = 195;
        int curFrame = 1;
        int totalFrames = 5; /*Maybe this*/
        int delay = 0;

        public LinkStabbingDown(IPlayer player, Texture2D texture)
        {
            this.texture = texture;
            this.player = player;
            this.linkDestWidth *= player.Size;
            this.linkDestHeight *= player.Size;
            this.swordDestWidth *= player.Size;
            this.swordDestHeight *= player.Size;
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
                    player.SetState(new PStateIdleDown(player));
                }
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle linkDestRec = new Rectangle((int)player.GetPosition().X, (int)player.GetPosition().Y, linkDestWidth, linkDestHeight);
            Rectangle linkSrcRec = new Rectangle(linkSrcX, linkSrcY, linkSrcWidth, linkSrcHeight);
            Rectangle swordSrcRec = new Rectangle(swordSrcX, swordSrcY, swordSrcWidth, swordSrcHeight);
            Rectangle swordDestRec;
            if (curFrame == 1)
            {
                swordDestRec = new Rectangle((int)player.GetPosition().X + 15, (int)player.GetPosition().Y + player.Size, swordDestWidth, swordDestHeight);
            }
            else if (curFrame == 2)
            {
                swordDestRec = new Rectangle((int)player.GetPosition().X + 15, (int)player.GetPosition().Y + 5 * player.Size, swordDestWidth, swordDestHeight);
            }
            else if (curFrame == 3 || curFrame == 4)
            {
                swordDestRec = new Rectangle((int)player.GetPosition().X + 15, (int)player.GetPosition().Y + 11 * player.Size, swordDestWidth, swordDestHeight);
            }
            else
            {
                swordDestRec = new Rectangle((int)player.GetPosition().X + 15, (int)player.GetPosition().Y + 5 * player.Size, swordDestWidth, swordDestHeight);
            }
            spriteBatch.Begin();
            spriteBatch.Draw(texture, swordDestRec, swordSrcRec, Color.White);
            spriteBatch.Draw(texture, linkDestRec, linkSrcRec, Color.White);
            spriteBatch.End();
        }
    }
}
