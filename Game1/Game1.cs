using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Game1.PlayerStates;
/*Authors: Mike Belair, Chase Armstrong*/
namespace Game1
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont text;
        List<IController> controllers;
        IPlayer player;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        public IPlayer GetPlayer()
        {
            return this.player;
        }

 
        protected override void Initialize()
        {
            player = new PlayerDefault(100, 100,new PStateIdleDown(this.player)); 
            controllers = new List<IController>();
            controllers.Add(new KeyboardController(this));
            //controllers.Add(new MouseController(this));
            this.IsMouseVisible = true;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

        }

   
        protected override void UnloadContent()
        {
  
        }

        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllers)
            {
                controller.Update();
            }
            player.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            player.Draw(spriteBatch);
            base.Draw(gameTime);
        }
    }
}
