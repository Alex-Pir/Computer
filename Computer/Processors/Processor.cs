using Computer.Interfaces;

namespace Computer.Processors
{
    public abstract class Processor : IMotherboardComponent, ISystemComponent
    {
        public abstract int GetMaxVoltage();

        public abstract int GetMemory();

        public abstract string GetName();

        public string GetComponentDescription()
        {
            return $"Processor {GetName()}. Memory {GetMemory()} KB";
        }
    }
}
