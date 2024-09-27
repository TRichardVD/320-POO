using Drones;


namespace testDrones

{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void MathTest()
        {
            // Arrange
            int a = 1;
            int b = 2;
            int result = 0;

            // Act
            result = a + b;

            // Assert
            Assert.AreEqual(3, result , "Le resultat doit etre 3");
        }

        [TestMethod]
        public void UpdateDroneTest()
        {
            // Arrange
            Drone testDrone = new Drone("test", 100, 100);

            // Act
            testDrone.Update(1);
            int result = testDrone.charge;

            // Assert
            Assert.IsTrue(result <= 1000);


        }



        [TestMethod]
        public void ChargeNewDrone() {
            
            // Arrange
            Drone testDrone = new Drone("hello", 100, 109);

            // Act
            int result = testDrone.charge;

            // Assert
            Assert.AreEqual(1000, result, "Lors de l'initialisation un drone doit avoir une charge de 1000");
        
        }

        [TestMethod]
        public void UpdateDroneTest2()
        {
            // Arrange
            Drone testDrone = new Drone("test", 100, 100);
            int oldCharge = testDrone.charge = 0;

            // Act
            testDrone.Update(1);
            int result = testDrone.charge;

            // Assert
            Assert.IsTrue(result == oldCharge);


        }

    }


}
