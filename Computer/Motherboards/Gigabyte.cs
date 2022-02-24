namespace Computer.Motherboards
{
    public class Gigabyte : Motherboard
    {
        protected override int GetMaxHddsCount()
        {
            return 3;
        }

        protected override int GetMaxMemoriesCount()
        {
            return 2;
        }

        public override string GetComponentDescription()
        {
            return "Motherboard Gigabyte";
        }
    }
}
