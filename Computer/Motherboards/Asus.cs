using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Motherboards
{
    public class Asus : Motherboard
    {
        public Asus() : base()
        {
            HddsCount = 2;
            MemoriesCount = 4;
        }

        public override string GetComponentDescription()
        {
            return "Motherboard Asus";
        }
    }
}
