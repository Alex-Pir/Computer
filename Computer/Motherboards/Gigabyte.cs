namespace Computer.Motherboards
{
    public class Gigabyte : Motherboard
    {
        public override int GetMaxHddsCount()
        {
            return 3;
        }

        public override int GetMaxMemoriesCount()
        {
            return 2;
        }

        public override string GetComponentDescription()
        {
            return "Motherboard Gigabyte";
        }
    }
}
