using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Processors
{
    public class IntelI5 : Processor
    {
        public override int GetMaxVoltage()
        {
            return 35;
        }

        public override int GetMemory()
        {
            return 7;
        }

        public override string GetName()
        {
            return "Intel i5";
        }
    }
}
