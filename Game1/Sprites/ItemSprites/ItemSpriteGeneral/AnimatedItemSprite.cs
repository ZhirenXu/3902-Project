using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Sprites
{
    public abstract class AnimatedItemSprite : ISprite
    {
        private Texture2D texture;
        private int rows;
        private int columns;
        private int currentFrame;
        private int totalFrames;
        double currentUpdateInterval;
        int FrameChangeDelay;
        public Rectangle Dimensions { get; set; }

        public AnimatedItemSprite(Texture2D texture, int rows, int columns) 
        {
            this.texture = texture;
            this.rows = rows;
            this.columns = columns;
            this.currentFrame = 0;
            totalFrames = this.rows * this.columns;
            int width = texture.Width / columns;
            int height = texture.Height / rows;
            Dimensions = new Rectangle(0, 0, width, height);
        }
        public void Update()
        {
            currentFrame++;
            if(currentFrame == totalFrames)
            {
                currentFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            int width = texture.Width / columns;
            int height = texture.Height / rows;
            int row = (int)(currentFrame / columns);
            int column = currentFrame % columns;

            Rectangle itemSrcRec = new Rectangle(width * column, height * row, width, height);
           // Rectangle itemSrcDest = new Rectangle((int)location.X, (int)location.Y, width, height);
           // spriteBatch.Draw(texture, itemSrcDest, itemSrcRec, Color.White);
        }
    }
}
