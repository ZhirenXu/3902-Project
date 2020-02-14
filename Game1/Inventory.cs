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
        public int TriforceShards { get; set; }
        public int CandleUsed { get; set; }
        public int HaveMap { get; set; }
        public int HaveCompass { get; set; }
        public int HaveWoodRang { get; set; }
        public int HaveBlueCandle { get; set; }
        public int HaveBow { get; set; }
        public int HaveBlueRing { get; set; }

        ICommand slotB;

        public Inventory()
        {
            Health = 6;
            HeartContainers = 3;
            Rupees = 0;
            Keys = 0;
            Bombs = 0;
            Arrows = 0;
            TriforceShards = 0;
            CandleUsed = 0;
            HaveMap = 0;
            HaveCompass = 0;
            HaveWoodRang = 0;
            HaveBlueCandle = 0;
            HaveBow = 0;
            HaveBlueRing = 0;

        }
        public ICommand GetSlotBCommand()
        {
            return slotB;
        }
        public void SetSlotBCommand(ICommand command)
        {
            slotB = command;
        }
    }
}
