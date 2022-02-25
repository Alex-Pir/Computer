namespace Computer.Motherboards
{
    public class Gigabyte : Motherboard
    {
        public Gigabyte() : base()
        {
            HddsCount = 3;
            MemoriesCount = 2;
        }

        public override string GetComponentDescription()
        {
            return "Motherboard Gigabyte";
        }
    }
}
