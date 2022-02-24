using Computer;
using Computer.Cards;
using Computer.Hdds;
using Computer.Memories;
using Computer.Motherboards;
using Computer.PowerUnits;
using Computer.Processors;

public class Program
{
    public static void Main(string[] args)
    {
        Motherboard motherboard = new Gigabyte();
        motherboard.Card = new RadeonRX470();

        motherboard.Hdds = new List<Hdd>
        {
            new Samsung(),
            new Toshiba(),
            new Toshiba()
        };

        motherboard.Memories = new List<Memory>
        {
            new Corsair(),
            new Patriot()
        };

        motherboard.Processor = new IntelI3();

        PowerUnit powerUnit = new Accord(); 

        MyComputer computer = new MyComputer(motherboard, powerUnit);

        try
        {
            if (computer.On())
            {
                Console.WriteLine("System start success");
            }
            else
            {
                Console.WriteLine("System start error: voltage is not enought");
            }
        } 
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
