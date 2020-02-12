using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class BombCommand : ICommand
    {
		private Game1 myGame;

		public BombCommand(Game1 game)
		{
			myGame = game;
		}

		public void Execute()
		{
			//decrement bombs from inventory
			//place bomb one tile away from link in the direction he's facing
			myGame.GetPlayer().SlotB();
		}
	}
}
