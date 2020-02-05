using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
	public class PlayerDefault : IPlayer
	{
		private Vector2 position;
		private IPlayerState state;
		public PlayerDefault(int x, int y, IPlayerState state)
		{
			this.position.X = x;
			this.position.Y = y;
			this.state = state;
		}

		public void setPosition(int x, int y)
		{
			this.position.X = x;
			this.position.Y = y;
		}

		public Vector2 getPosition()
		{
			return this.position;
		}

		public void changeState(IPlayerState state)
		{
			this.state = state;
		}

		public IPlayerState getState()
		{
			return this.state;
		}



	}
}