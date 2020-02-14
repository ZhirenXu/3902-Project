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
            if (Keyboard.GetState().IsKeyDown(Keys.Z) || Keyboard.GetState().IsKeyDown(Keys.N) || Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                myGame.GetPlayer().SlotA();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D1) || Keyboard.GetState().IsKeyDown(Keys.NumPad1))
            {
                myGame.GetPlayer().SlotB();
            }
            else if ((Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.Up)) && !((Keyboard.GetState().IsKeyDown(Keys.S) || Keyboard.GetState().IsKeyDown(Keys.Down))))
            {
                myGame.GetPlayer().MoveUp();
            }
            else if(Keyboard.GetState().IsKeyDown(Keys.S) || Keyboard.GetState().IsKeyDown(Keys.Down) && !((Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.Up))))
            {
                myGame.GetPlayer().MoveDown();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.Left) && !((Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.Right))))
            {
                myGame.GetPlayer().MoveLeft();
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.Right) && !((Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.Left))))
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

