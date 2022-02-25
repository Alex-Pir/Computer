using Computer.Interfaces;

namespace Computer.PowerUnits
{
    public abstract class PowerUnit : ISystemComponent
    {
        public abstract string GetComponentDescription();
        public abstract int GetVoltage();
    }
}
