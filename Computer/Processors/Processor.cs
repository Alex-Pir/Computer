using Computer.Interfaces;

namespace Computer.Processors
{
    public abstract class Processor : IMotherboardComponent, ISystemComponent
    {
        public abstract int GetMaxVoltage();
        public abstract string GetComponentDescription();
    }
}
