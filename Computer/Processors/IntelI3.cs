using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Processors
{
    public class IntelI3 : Processor
    {
        public override int GetMaxVoltage()
        {
            return 25;
        }

        public override int GetMemory()
        {
            return 5;
        }

        public override string GetName()
        {
            return "Intel i3";
        }
    }
}
