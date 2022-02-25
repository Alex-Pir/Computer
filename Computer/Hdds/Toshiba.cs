namespace Computer.Hdds
{
    public class Toshiba : Hdd
    {
        public override int GetMaxVoltage()
        {
            return 25;
        }

        public override int GetMemory()
        {
            return 500000;
        }

        public override string GetName()
        {
            return "Toshiba";
        }
    }
}
