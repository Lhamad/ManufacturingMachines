using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Machine.BL;

namespace MachineDescription
{
    [TestClass]
    public class MachineDescriptionTest
    {
        [TestMethod]
        public void MachineDescriptionValid()
        {
            // -- Arrange

            machine machine = new machine();

            machine.MachineName = "HC06";
            machine.MachineType = "Cutter";

            string expected = "Cutter: HC06";


            // -- Act

            string actual = machine.MachineDescription;

            // -- Assert

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void MachineTypeisEmpty()
        {
            // -- Arrange

            machine machine = new machine();

            machine.MachineName = "HC06";


            string expected = "HC06";


            // -- Act

            string actual = machine.MachineDescription;

            // -- Assert

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void MachineNameisEmpty()
        {
            // -- Arrange

            machine machine = new machine();

            machine.MachineType = "Cutter";


            string expected = "Cutter";


            // -- Act

            string actual = machine.MachineDescription;

            // -- Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InstanceCountTest()
        {
            // -- Arrange

            var mach1 = new machine();
            mach1.MachineType = "Cutter";
            machine.MachineCount += 1;

            var mach2 = new machine();
            mach1.MachineType = "Bender";
            machine.MachineCount += 1;

            var mach3 = new machine();
            mach1.MachineType = "Tester";
            machine.MachineCount += 1;


            // Assert

            Assert.AreEqual(3, machine.MachineCount);
        }


        public void ValidateValid()
        {

            // -- Arrange

            var machine = new machine
            {
                MachineName = "HC06",
               
            };

            

            // -- Act

            var expected = true;

            //-- Act
            var actual = machine.Validate();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

