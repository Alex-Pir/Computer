using Computer.Interfaces;

namespace Computer.Memories
{
    public abstract class Memory : IMotherboardComponent, ISystemComponent
    {
        public abstract int GetMemory();
        public abstract int GetMaxVoltage();
        public abstract string GetName();

        public string GetComponentDescription()
        {
            return $"RAM {GetName()}. Memory {GetMemory()}";
        }
    }
}
