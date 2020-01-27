using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{

    public class MouseController : IController
    {
        Game1 myGame;
        public MouseController(Game1 game)
        {
            myGame = game;
        }

        public void Update()
        {
            if (Mouse.GetState().RightButton == ButtonState.Pressed){
                myGame.Exit(); 
            }
            else if (Mouse.GetState().X<400 && Mouse.GetState().Y<240 && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                myGame.SetPlayerSprite(new SpriteNMNA(myGame));
            }
            else if (Mouse.GetState().X > 400 && Mouse.GetState().Y < 240 && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                myGame.SetPlayerSprite(new SpriteNMA(myGame));
            }
            else if (Mouse.GetState().X < 400 && Mouse.GetState().Y > 240 && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                myGame.SetPlayerSprite(new SpriteMNA(myGame));
            }
           else  if (Mouse.GetState().X > 400 && Mouse.GetState().Y > 240 && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                myGame.SetPlayerSprite(new SpriteMA(myGame));
            }
        }
       
    }
}

