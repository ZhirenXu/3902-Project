using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class BluePotionCommand : ICommand
    {
		private Game1 myGame;

		public BluePotionCommand(Game1 game)
		{
			myGame = game;
		}

		public void Execute()
		{
			//restore all hearts
			//remove potion from inventory
			myGame.GetPlayer().SlotB();
		}
	}
}
