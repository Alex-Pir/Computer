using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Cards
{
    public class RadeonRX470 : VideoCard
    {
        public override int GetMemory()
        {
            return 4;
        }

        public override int GetMaxVoltage()
        {
            return 500;
        }

        public override string GetName()
        {
            return "Radeon RX 470";
        }
    }
}
