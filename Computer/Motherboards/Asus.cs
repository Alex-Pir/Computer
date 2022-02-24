using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Motherboards
{
    public class Asus : Motherboard
    {
        protected override int GetMaxHddsCount()
        {
            return 2;
        }

        protected override int GetMaxMemoriesCount()
        {
            return 4;
        }

        public override string GetComponentDescription()
        {
            return "Motherboard Asus";
        }
    }
}
