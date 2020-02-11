using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Game1.PlayerStates;
using Game1.Projectiles;
using System.Collections.Generic;

namespace Game1
{
	public class PlayerDefault : IPlayer
	{
		private Vector2 position;
		private IPlayerState state;
		List<IProjectile> projectiles;
		int maxHealth;
		int health;

		public PlayerDefault(int x, int y, int health, int maxHealth)
		{
			this.Speed = 5;                /*Changeable*/
			this.Size = 3;                 /************/
			this.position = new Vector2(); 
			this.position.X = x;
			this.position.Y = y;
			this.health = health;
			this.maxHealth = maxHealth;
			this.state = new PStateIdleDown(this);
			projectiles = new List<IProjectile>();           /*Projectiles*/
			this.InitializeProjectiles();
		}

        public int Speed { get; set; }
		public int Size { get; set; }
		public void InitializeProjectiles()
		{
			projectiles.Add(new ProjLinkArrowDown(this));
															//Add more projectiles here for now...
		}
		public List<IProjectile> GetProjectiles()
		{
			return this.projectiles;
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
			foreach (IProjectile projectile in projectiles)
			{
				projectile.Update();
			}
			state.Update();
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			foreach (IProjectile projectile in projectiles)
			{
				projectile.Draw(spriteBatch);
			}
			state.Draw(spriteBatch);
		}


	}
}