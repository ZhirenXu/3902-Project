using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class BombCommand : ICommand
    {
		private IPlayer player;
		private IInventory inventory;

		public BombCommand(Game1 game)
		{
			Initialize(player);
		}

		public void Initialize(IPlayer player)
		{
			this.player = player;
			inventory = player.GetInventory();
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
