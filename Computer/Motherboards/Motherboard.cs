using Computer.Cards;
using Computer.Hdds;
using Computer.Memories;
using Computer.Processors;
using Computer.Interfaces;

namespace Computer.Motherboards
{
    public abstract class Motherboard : ISystemComponent
    {
        public Processor? Processor { get; set; }

        public VideoCard? Card { get; set; }

        public List<Memory> Memories { get; set; }

        public List<Hdd> Hdds { get; set; }

        public int MemoriesCount { get; protected set; }

        public int HddsCount { get; protected set; }

        private int Voltage = 0;

        public bool SystemStart { get; private set; }

        public Motherboard()
        {
            Hdds = new List<Hdd> { };

            Memories = new List<Memory> { };

            SystemStart = true;

            MemoriesCount = 1;
            HddsCount = 1;
        }

        public bool Start(int voltage = 0)
        {

            if (voltage < 0)
            {
                throw new ArgumentException("Voltage cannot be negative");
            }

            Voltage = voltage;

            if (Processor == null
                || Memories == null
                || Card == null
                || Hdds == null
                )
            {
                throw new Exception("Not found all required hardware");
            }

            HddsCheck();
            MemoriesCheck();

            ElementStart(Processor);
            ElementStart(Card);

            foreach (Memory memoryCard in Memories)
            {
                ElementStart(memoryCard);
            }

            foreach (Hdd hdds in Hdds)
            {
                ElementStart(hdds);
            }
       
            return SystemStart;
        }

        protected void HddsCheck()
        {
            if (Hdds.Count > HddsCount)
            {
                throw new Exception($"You can only add {HddsCount} HDD");
            }
        }

        protected void MemoriesCheck()
        {
            if (Memories.Count > MemoriesCount)
            {
                throw new Exception($"You can only add {MemoriesCount} RAM");
            }
        }

        protected bool ElementStart(IMotherboardComponent component)
        {
            Voltage -= component.GetMaxVoltage();

            if (Voltage < 0)
            {
                SystemStart = false;
            }

            return SystemStart;
        }

        public abstract string GetComponentDescription();
    }
}
