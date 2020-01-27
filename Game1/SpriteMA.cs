using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class SpriteMA : ISprite
    {
        Game1 myGame;
        private Texture2D texture;
        private int currentFrame;
        private int totalFrames;
        private int delay;
        public SpriteMA(Game1 game)
        {
            myGame = game;
            texture = myGame.luigi;
            currentFrame = 1;
            totalFrames = 4;
            delay = 0;
        }

        public void Update()
        {
            delay++;
            if (delay == 7)
            {
                delay = 0;
                currentFrame++;
                if (currentFrame == totalFrames + 1)
                {
                    currentFrame = 2;
                }
            }
            myGame.SetPlayerPos((int)myGame.playerPos.X - 6,(int)myGame.playerPos.Y);
            if (myGame.playerPos.X < -75)
            {
                myGame.SetPlayerPos(775, (int)myGame.playerPos.Y);
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRec;
            if (currentFrame == 1) {
                sourceRec = new Rectangle(175, 0, 25, 20);
            }
            else if(currentFrame == 2)
            {
                sourceRec = new Rectangle(144, 0, 25, 20);
            }
            else if(currentFrame == 3)
            {
                sourceRec = new Rectangle(115, 0, 25, 20);
            }
            else
            {
                sourceRec = new Rectangle(84, 0, 25, 20);
            }
            Rectangle destRec = new Rectangle((int)myGame.playerPos.X, (int)myGame.playerPos.Y, 100, 80);

            spriteBatch.Begin();
            spriteBatch.Draw(texture, destRec, sourceRec, Color.White);
            spriteBatch.End();
        }
        
    }
}
