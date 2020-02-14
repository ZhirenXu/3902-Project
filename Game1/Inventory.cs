using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Inventory : IInventory
    {
        public int Health { get; set; }
        public int HeartContainers { get; set; }
        public int Rupees { get; set; }
        public int Keys { get; set; }
        public int Bombs { get; set; }
        public int Arrows { get; set; }
        public int Map { get; set; }
        public int Compass { get; set; }
        public int CandleUsed { get; set; }
        ICommand slotB;

        public Inventory()
        {
            Health = 6;
            HeartContainers = 3;
            Rupees = 0;
            Keys = 0;
            Bombs = 0;
            Arrows = 0;
            Map = 0;
            Compass = 0;
            CandleUsed = 0;
        }
        public ICommand GetSlotBCommand()
        {
            return slotB;
        }
        public void SetSlotBCommand(ICommand command)
        {

        }
    }
}
