using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class BlueCandleCommand : ICommand
    {
		private Game1 myGame;

		public BlueCandleCommand(Game1 game)
		{
			myGame = game;
		}

		public void Execute()
		{
			//if already used in screen, do nothing & end command
			//create fire projectile
			//if room is dark, light room
			myGame.GetPlayer().SlotB();
		}
	}
}
