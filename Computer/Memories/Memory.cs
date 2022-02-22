using Computer.Interfaces;

namespace Computer.Memories
{
    public abstract class Memory : IMotherboardComponent, ISystemComponent
    {
        public abstract int GetMaxVoltage();
        public abstract string GetComponentDescription();
    }
}
