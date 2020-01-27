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
            if (Keyboard.GetState().IsKeyDown(Keys.D0) || Keyboard.GetState().IsKeyDown(Keys.NumPad0)){
                myGame.Exit(); 
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D1) || Keyboard.GetState().IsKeyDown(Keys.NumPad1))
            {
                myGame.SetPlayerSprite(new SpriteNMNA(myGame));
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D2) || Keyboard.GetState().IsKeyDown(Keys.NumPad2))
            {
                myGame.SetPlayerSprite(new SpriteNMA(myGame));
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.D3) || Keyboard.GetState().IsKeyDown(Keys.NumPad3))
            {
                myGame.SetPlayerSprite(new SpriteMNA(myGame));
            }
           else  if (Keyboard.GetState().IsKeyDown(Keys.D4) || Keyboard.GetState().IsKeyDown(Keys.NumPad4))
            {
                myGame.SetPlayerSprite(new SpriteMA(myGame));
            }
        }
       
    }
}

