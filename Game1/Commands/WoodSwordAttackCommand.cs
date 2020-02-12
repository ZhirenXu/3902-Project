using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class WoodSwordAttackCommand : ICommand
    {
		private Game1 myGame;

		public WoodSwordAttackCommand(Game1 game)
		{
			myGame = game;
		}

		public void Execute()
		{
			//sword attack action, whatever that is
			
		}
	}
}
