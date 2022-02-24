namespace Computer.PowerUnits
{
    public class Accord : PowerUnit
    {
        public override string GetComponentDescription()
        {
            return "Power unit Accord";
        }

        public override int GetVoltage()
        {
            return 750;
        }
    }
}
