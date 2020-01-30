using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
/*Authors: Mike Belair, */
namespace Game1
{
    public class Game1 : Game
    {
        public Texture2D luigi;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont text;
        List<IController> controllers;
        ISprite playerSprite;
        Vector2 playerPosition;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        public Vector2 playerPos
        {
            get { return playerPosition; }
        }
        public void SetPlayerPos(int x, int y)
        {
            playerPosition.X = x;
            playerPosition.Y = y;
        }

        public void SetPlayerSprite(ISprite sprite)
        {
            playerSprite = sprite;
        }
        protected override void Initialize()
        {
            playerPosition.X = 350;
            playerPosition.Y = 200;
            controllers = new List<IController>();
            controllers.Add(new KeyboardController(this));
            controllers.Add(new MouseController(this));
            this.IsMouseVisible = true;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            luigi = Content.Load<Texture2D>("luigi");
            text = Content.Load<SpriteFont>("font");
            playerSprite = new SpriteNMNA(this);
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
            playerSprite.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            playerSprite.Draw(spriteBatch);
            spriteBatch.Begin();
            spriteBatch.DrawString(text, "Credits\nProgram by: Mike Belair\nSprites from: http://www.mariouniverse.com/sprites/nes/",new Vector2(100,400), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
