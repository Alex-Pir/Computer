using Computer.Interfaces;

namespace Computer.Cards
{
    public abstract class VideoCard : IMotherboardComponent, ISystemComponent
    {
        public abstract int GetMemory();
        public abstract int GetMaxVoltage();
        public abstract string GetName();
        public string GetComponentDescription()
        {
            return $"Video card: {GetName()}. Video Memory: {GetMemory()} GB";
        }
    }
}
