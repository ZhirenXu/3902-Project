using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Game1.PlayerStates;

namespace Game1
{
	public class PlayerDefault : IPlayer
	{
		private Vector2 position;
		private IPlayerState state;
		int width;
		int height;
		public PlayerDefault(int x, int y)
		{
			this.Speed = 5;                /*Changeable*/
			this.Width = 45;               /*Must be a multiple of 15*/
			this.Height = 48;              /*Must be a multiple of 16*/
			this.position = new Vector2(); 
			this.position.X = x;
			this.position.Y = y;
			this.state = new PStateIdleDown(this);
		}

        public int Speed { get; set; }
		public int Width { get; set; } 
		public int Height { get; set; } 
		public void SetPosition(int x, int y)
		{
			this.position.X = x;
			this.position.Y = y;
		}

		public Vector2 GetPosition()
		{
			return this.position;
		}

		public void SetState(IPlayerState state)
		{
			this.state = state;
		}

		public IPlayerState GetState()
		{
			return this.state;
		}

		public void MoveUp()
		{
			state.MoveUp();
		}

		public void MoveDown()
		{
			state.MoveDown();
		}

		public void MoveLeft()
		{
			state.MoveLeft();
		}

		public void MoveRight()
		{
			state.MoveRight();
		}

		public void SlotA()
		{
			state.SlotA();
		}

		public void SlotB()
		{
			state.SlotB();
		}

		public void Stop()
		{
			state.Stop();
		}

		public void Update()
		{
			state.Update();
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			state.Draw(spriteBatch);
		}


	}
}