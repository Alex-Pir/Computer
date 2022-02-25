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

namespace ComputerTests
{
    public class MotherboardTest
    {

        [Test]
        public void Motherboard_Start_VideoCardNull_Exception()
        {
            //Arrange
            Motherboard motherboard = MotherboardInit();
            motherboard.Card = null;

            int voltage = 750;

            //Assert
            Exception ex = Assert.Throws<Exception>(() => { motherboard.Start(voltage); });
            Assert.That(ex.Message, Is.EqualTo("Not found all required hardware"));
        }

        [Test]
        public void Motherboard_Start_VoltageIsNegative_ArgumentException()
        {
            //Arrange
            Motherboard motherboard = MotherboardInit();

            int voltage = -20;

            //Assert
            Exception ex = Assert.Throws<ArgumentException>(() => { motherboard.Start(voltage); });
            Assert.That(ex.Message, Is.EqualTo("Voltage cannot be negative"));
        }

        [Test]
        public void Motherboard_Start_ToManyHdds_Exception()
        {
            //Arrange
            Motherboard motherboard = MotherboardInit();
            motherboard.Hdds.Add(new Samsung());
            motherboard.Hdds.Add(new Samsung());

            int voltage = 750;

            //Act
            int maxHddsCount = motherboard.GetMaxHddsCount();

            //Assert
            Exception ex = Assert.Throws<Exception>(() => { motherboard.Start(voltage); });
            Assert.That(ex.Message, Is.EqualTo($"You can only add { maxHddsCount } HDD"));
        }

        [Test]
        public void Motherboard_Start_ToManyRAM_Exception()
        {
            //Arrange
            Motherboard motherboard = MotherboardInit();
            motherboard.Memories.Add(new Patriot());

            int voltage = 750;

            //Act
            int maxRAMCount = motherboard.GetMaxMemoriesCount();

            //Assert
            Exception ex = Assert.Throws<Exception>(() => { motherboard.Start(voltage); });
            Assert.That(ex.Message, Is.EqualTo($"You can only add { maxRAMCount } RAM"));
        }

        protected Motherboard MotherboardInit()
        {
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

            return motherboard;
        }
    }
}
