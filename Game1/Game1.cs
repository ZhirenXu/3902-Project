using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Game1.PlayerStates;
using Game1.Projectiles;
/*Authors: Mike Belair, Chase Armstrong, Zhiren Xu, Xian Zhang, Simon Manning */
namespace Game1
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Rectangle backgroundSrcRec;
        Rectangle backgroundDestRec;
        //SpriteFont text;
        List<IController> controllers;
        IPlayer player;
        IEnemy enemy;
        private Texture2D background;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        public IPlayer GetPlayer()
        {
            return this.player;
        }
        public IEnemy GetEnemy()
        {
            return this.enemy;
        }

        protected override void Initialize()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            SpriteFactory.Instance.LoadAll(Content);
            player = new PlayerDefault(100, 100, 6, 6, GraphicsDevice);
            enemy = new EnemyDefault(500, 300, 3, 6, GraphicsDevice);
            this.backgroundSrcRec = new Rectangle(257, 0, 256, 176);
            this.backgroundDestRec = new Rectangle(0, 0, spriteBatch.GraphicsDevice.Viewport.Width, spriteBatch.GraphicsDevice.Viewport.Height);
            controllers = new List<IController>();           /*Controllers*/
            controllers.Add(new KeyboardController(this));
            //controllers.Add(new MouseController(this));
            this.IsMouseVisible = true;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            background = Content.Load<Texture2D>("ProjectSpriteSheets/dungeon");
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
            enemy.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, backgroundDestRec, backgroundSrcRec, Color.White);
            spriteBatch.End();
            //GraphicsDevice.Clear(Color.CornflowerBlue);
            enemy.Draw(spriteBatch);
            player.Draw(spriteBatch);
            base.Draw(gameTime);
        }
    }
}
