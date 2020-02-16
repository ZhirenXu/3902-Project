using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Game1.PlayerStates;
using System;

namespace Game1.ItemSprites
{
    class ArrowSprite : ISprite
    {
        Texture2D texture;
        ISprite item;
        int arrowSrcWidth = 15;
        int arrowSrcHeight = 15;
        int arrowDestWidth = 15;
        int arrowDestHeight = 15;
        int arrowSrcX = 119;
        int arrowSrcY = 195;
        int arrowDestX = 20;
        int arrowDestY = 20;

        public ArrowSprite(ISprite item, Texture2D texture)
        {
            this.texture = texture;
            this.item = item;
        }
        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle arrowSrcRec = new Rectangle(arrowSrcX, arrowSrcY, arrowSrcWidth, arrowSrcHeight);
            Rectangle arrowDestRec = new Rectangle(arrowDestX, arrowDestY, arrowDestWidth, arrowDestHeight);
            spriteBatch.Begin();
            spriteBatch.Draw(texture, arrowDestRec, arrowSrcRec, Color.White);
            spriteBatch.End();
        }
    }
}
