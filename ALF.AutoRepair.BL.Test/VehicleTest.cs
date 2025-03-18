namespace ALF.AutoRepair.BL.Test
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void ConstructorTest1()
        {
            Vehicle vehicle = new Vehicle("A", "A", 2000);
            int actual = vehicle.Year;
            int expected = 2000;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConstructorTest2()
        {
            Vehicle vehicle = new Vehicle();
            int actual = vehicle.Year;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConstructorTest3()
        {
            Vehicle? vehicle = new Vehicle();
            Assert.IsNotNull(vehicle);
        }
    }
}