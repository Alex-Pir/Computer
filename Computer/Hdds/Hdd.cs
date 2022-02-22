using Computer.Interfaces;

namespace Computer.Hdds
{
    public abstract class Hdd : IMotherboardComponent, ISystemComponent
    {
        public abstract int GetMaxVoltage();
        public abstract string GetComponentDescription();
    }
}
