using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class BluePotionCommand : ICommand
    {
		private Game1 myGame;
		private IInventory inventory;

		public BluePotionCommand(Game1 game)
		{
			myGame = game;
			inventory = game.GetPlayer().GetInventory();
		}

		public void Execute()
		{
			inventory.Health = inventory.HeartContainers;
			//remove potion from inventory
		}
	}
}
