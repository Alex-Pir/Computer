using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Memories
{
    public class Patriot : Memory
    {
        public override int GetMaxVoltage()
        {
            return 20;
        }

        public override int GetMemory()
        {
            return 10;
        }

        public override string GetName()
        {
            return "Patriot";
        }
    }
}
