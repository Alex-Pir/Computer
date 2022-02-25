namespace Computer.PowerUnits
{
    public class Aercool : PowerUnit
    {
        public override string GetComponentDescription()
        {
            return "Power Unit Aercool";
        }

        public override int GetVoltage()
        {
            return 500;
        }
    }
}
