﻿using Microsoft.Xna.Framework;
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

		public void Attack()
		{
			state.Attack();
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