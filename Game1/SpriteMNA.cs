using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class SpriteMNA : ISprite
    {
        Game1 myGame;
        private Texture2D texture;
        public SpriteMNA(Game1 game)
        {
            texture = game.luigi;
            myGame = game;
        }

        public void Update()
        {
            myGame.SetPlayerPos((int)myGame.playerPos.X, (int)myGame.playerPos.Y-6);
            if(myGame.playerPos.Y < -50)
            {
                myGame.SetPlayerPos((int)myGame.playerPos.X,480);
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRec = new Rectangle(175, 0, 25, 20);
            Rectangle destRec = new Rectangle((int)myGame.playerPos.X, (int)myGame.playerPos.Y, 100, 80);

            spriteBatch.Begin();
            spriteBatch.Draw(texture, destRec, sourceRec, Color.White);
            spriteBatch.End();
        }
        
    }
}
