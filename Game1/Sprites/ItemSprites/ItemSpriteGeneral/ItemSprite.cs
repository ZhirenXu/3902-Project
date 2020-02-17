using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Sprites
{
    public abstract class ItemSprite : ISprite
    {
        private Texture2D texture { get; set; }

        public Rectangle Dimensions { get; set; }

        /*public ISprite itemSprite(Texture2D texture)
        {
            this.texture = texture;
            Dimensions = texture.Bounds;
    
        }*/
        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
           // Rectangle itemSrcDest = new Rectangle((int)location.X, (int)location.Y,texture.Width, texture.Height);
            //spriteBatch.Draw(texture, itemSrcDest, Color.White);
        }
    }
}
