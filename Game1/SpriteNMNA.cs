using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class SpriteNMNA : ISprite
    {
        Game1 myGame;
        private Texture2D texture;
        public SpriteNMNA(Game1 game)
        {
            myGame = game;
            texture = myGame.luigi;
        }

        public void Update()
        {
            
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
