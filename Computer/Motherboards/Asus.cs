using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Motherboards
{
    public class Asus : Motherboard
    {
        public override int GetMaxHddsCount()
        {
            return 2;
        }

        public override int GetMaxMemoriesCount()
        {
            return 4;
        }

        public override string GetComponentDescription()
        {
            return "Motherboard Asus";
        }
    }
}
