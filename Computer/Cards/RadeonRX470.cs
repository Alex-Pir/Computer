namespace Computer.Cards
{
    public class RadeonRX470 : VideoCard
    {
        public override int GetMemory()
        {
            return 4;
        }

        public override int GetMaxVoltage()
        {
            return 500;
        }

        public override string GetName()
        {
            return "Radeon RX 470";
        }
    }
}
