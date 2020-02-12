using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class UseSwordCommand : ICommand
    {
		private Game1 myGame;

		public UseSwordCommand(Game1 game)
		{
			myGame = game;
		}

		public void Execute()
		{
			//if full hearts create swordbeam projectile
			//start sword attack animation
			
		}
	}
}
