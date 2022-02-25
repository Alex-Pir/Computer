using Computer.Interfaces;

namespace Computer.Hdds
{
    public abstract class Hdd : IMotherboardComponent, ISystemComponent
    {
        public abstract int GetMemory();
        public abstract int GetMaxVoltage();
        public abstract string GetName();

        public string GetComponentDescription()
        {
            return $"HDD {GetName()}. Memory {GetMemory()} GB";
        }
    }
}
