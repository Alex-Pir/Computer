using NUnit.Framework;
using System.Collections.Generic;
using Computer.Motherboards;
using Computer.Cards;
using Computer.Hdds;
using Computer.Memories;
using Computer.Processors;
using Computer.PowerUnits;
using Computer;
using System;

namespace ComputerStart
{
    public class Tests
    {
        [Test]
        public void Computer_On_VoltageEnought_ReturnsTrue()
        {
            //Arrange
            Motherboard motherboard = new Gigabyte();
            motherboard.Card = new RadeonRX470();

            motherboard.Hdds = new List<Hdd>
        {
            new Samsung(),
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

            var startResult = false;

            //Act
            startResult = computer.On();


            Assert.AreEqual(true, startResult);
        }

        [Test]
        public void Computer_On_VoltageNotEnought_ReturnsFalse()
        {
            //Arrange
            Motherboard motherboard = new Gigabyte();
            motherboard.Card = new RadeonRX470();

            motherboard.Hdds = new List<Hdd>
        {
            new Samsung(),
            new Toshiba()
        };

            motherboard.Memories = new List<Memory>
        {
            new Corsair(),
            new Patriot()
        };

            motherboard.Processor = new IntelI3();

            PowerUnit powerUnit = new Aercool();

            MyComputer computer = new MyComputer(motherboard, powerUnit);

            var startResult = false;

            //Act
            startResult = computer.On();


            Assert.AreEqual(false, startResult);
        }
    }
}