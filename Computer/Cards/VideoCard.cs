using Computer.Interfaces;

namespace Computer.Cards
{
    public abstract class VideoCard : IMotherboardComponent, ISystemComponent
    {
        public abstract int GetMaxVoltage();
        public abstract string GetComponentDescription();
    }
}
