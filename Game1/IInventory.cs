using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1 {
    public interface IInventory
    {
        int Health { get; set; }
        int HeartContainers { get; set; }
        int Rupees { get; set; }
        int Keys { get; set; }
        int Bombs { get; set; }
        int Arrows { get; set; }
        int Map { get; set; }
        int Compass { get; set; }
        int CandleUsed { get; set; }
        ICommand GetSlotBCommand();
        void SetSlotBCommand(ICommand command);
    }
}