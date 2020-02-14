using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class BombCommand : ICommand
    {
		private Game1 myGame;
		private IInventory inventory;

		public BombCommand(Game1 game)
		{
			myGame = game;
			inventory = game.GetPlayer().GetInventory();
		}

		public void Execute()
		{
			if (inventory.Bombs != 0)
			{
				inventory.Bombs--;
				//place bomb one tile away from link in the direction he's facing
			}
		}
	}
}
