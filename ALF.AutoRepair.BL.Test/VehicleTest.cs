namespace ALF.AutoRepair.BL.Test
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void ConstructorTest1()
        {
            VehicleTest vehicle = new VehicleTest("A", "A", 2000);
            int actual = vehicle.Year;
            int expected = 2000;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConstructorTest2()
        {
            VehicleTest vehicle = new VehicleTest("A", "A", 2000);
            string actual = vehicle.Year;
            string expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}