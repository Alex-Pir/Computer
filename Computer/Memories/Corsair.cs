using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Memories
{
    public class Corsair : Memory
    {
        public override int GetMaxVoltage()
        {
            return 15;
        }

        public override int GetMemory()
        {
            return 8;
        }

        public override string GetName()
        {
            return "Corsair";
        }
    }
}
