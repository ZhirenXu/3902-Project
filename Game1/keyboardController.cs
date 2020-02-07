using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{

    public class KeyboardController : IController
    {
        Game1 myGame;
        public KeyboardController(Game1 game)
        {
            myGame = game;
        }

        public void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.Up)){
                myGame.GetPlayer().MoveUp();
            }
            else if(Keyboard.GetState().IsKeyDown(Keys.S) || Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                myGame.GetPlayer().MoveDown();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                myGame.GetPlayer().MoveLeft();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                myGame.GetPlayer().MoveRight();
            }
            else
            {
                myGame.GetPlayer().Stop();
            }

        }
       
    }
}

