using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class WoodRangCommand : ICommand
    {
		private Game1 myGame;

		public WoodRangCommand(Game1 game)
		{
			myGame = game;
		}

		public void Execute()
		{
			//create wood rang projectile

			myGame.GetPlayer().SlotB();
		}
	}
}
