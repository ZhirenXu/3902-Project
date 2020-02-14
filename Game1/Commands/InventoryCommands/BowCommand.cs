using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class BowCommand : ICommand
    {
		private Game1 myGame;
		private IInventory inventory;

		public BowCommand(Game1 game)
		{
			myGame = game;
			inventory = game.GetPlayer().GetInventory();
		}

		public void Execute()
		{
			if (inventory.Arrows != 0)
			{
				//create arrorow projectile
				inventory.Arrows--;
			}
		}
	}
}
