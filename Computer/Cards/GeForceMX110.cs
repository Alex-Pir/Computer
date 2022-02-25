namespace Computer.Cards
{
    public class GeForceMX110 : VideoCard
    {
        public override int GetMemory()
        {
            return 16;
        }

        public override int GetMaxVoltage()
        {
            return 650;
        }

        public override string GetName()
        {
            return "GeForce MX110";
        }
    }
}
