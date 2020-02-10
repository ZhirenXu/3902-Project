using Game1.PlayerStates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1.PlayerSprites
{
    class LinkDamagedUp :ISprite
    {
        Texture2D texture;
        IPlayer player;
        int srcWidth = 15;
        int srcHeight = 16;
        int destWidth = 15;
        int destHeight = 16;
        int srcX = 60; /*Change this*/
        int srcY = 0;  /*and this*/
        int curFrame = 1;
        int totalFrame = 10;
        int coolDown = 20;
        int tick = 0;

        public LinkDamagedUp(IPlayer player, Texture2D texture)
        {
            this.texture = texture;
            this.player = player;
            this.destWidth *= player.Size;
            this.destHeight *= player.Size;
        }
        public void Update()
        {
            tick++;
            if (tick == 7)
            {
                tick = 0;
                srcX += 120;
                curFrame++;
                if (curFrame <= totalFrame)
                {
                    if (srcX == 420)
                    {
                        srcX = 60;
                    }
                }
                else
                {
                    player.SetState(new PStateIdleUp(player, coolDown));
                }
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle destRec = new Rectangle((int)player.GetPosition().X, (int)player.GetPosition().Y, destWidth, destHeight);
            Rectangle srcRec;
            srcRec = new Rectangle(srcX, srcY, srcWidth, srcHeight);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, destRec, srcRec, Color.White);
            spriteBatch.End();
        }
    }
}
