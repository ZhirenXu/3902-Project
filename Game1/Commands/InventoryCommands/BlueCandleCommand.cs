using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class BlueCandleCommand : ICommand
    {
		private Game1 myGame;
		private IInventory inventory;

		public BlueCandleCommand(Game1 game)
		{
			myGame = game;
			inventory = myGame.GetPlayer().GetInventory();
		}

		public void Execute()
		{
			if (inventory.CandleUsed == 1)
			{
				//do nothing
			} else
			{
				//create fire projectile
				//if room is dark, light room
			}
		}
	}
}
