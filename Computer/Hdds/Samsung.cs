using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Hdds
{
    public class Samsung : Hdd
    {
        public override int GetMaxVoltage()
        {
            return 20;
        }

        public override int GetMemory()
        {
            return 250000;
        }

        public override string GetName()
        {
            return "Samsung";
        }
    }
}
