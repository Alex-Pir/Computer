using Computer.Motherboards;
using Computer.PowerUnits;
using Computer.Interfaces;

namespace Computer
{
    public class MyComputer
    {
        public Motherboard Motherboard { get; set; }

        public PowerUnit PowerUnit { get; set; }

        public MyComputer(Motherboard motherboard, PowerUnit powerUnit)
        {
            Motherboard = motherboard;
            PowerUnit = powerUnit;
        }

        public bool On()
        {
            int voltage = PowerUnit.GetVoltage();

            PrintComponentInfo(PowerUnit);

            Motherboard.Start(voltage);

            PrintComponentInfo(Motherboard);
            PrintComponentInfo(Motherboard.Processor);
            PrintComponentInfo(Motherboard.Card); 

            foreach (Memories.Memory memory in Motherboard.Memories)
            {
                PrintComponentInfo(memory);
            }

            foreach (Hdds.Hdd hdd in Motherboard.Hdds)
            {
                PrintComponentInfo(hdd);
            }

            return Motherboard.SystemStart;
        }

        protected void PrintComponentInfo(ISystemComponent component)
        {
            Console.WriteLine(component.GetComponentDescription());
        }
    }
}
