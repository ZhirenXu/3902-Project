using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class WoodRangCommand : ICommand
    {
		private Game1 myGame;
		private IInventory inventory;

		public WoodRangCommand(Game1 game)
		{
			myGame = game;
			inventory = game.GetPlayer().GetInventory();
		}

		public void Execute()
		{
			//create wood rang projectile
		}
	}
}
