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
            Drone testDrone = new Drone(100, 100, "test");

            // Act
            testDrone.Update(1);
            int result = testDrone.charge;

            // Assert
            Assert.IsTrue(result <= 1000);


        }



        [TestMethod]
        public void ChargeNewDrone() {
            
            // Arrange
            Drone testDrone = new Drone(100, 109, "hello");

            // Act
            int result = testDrone.charge;

            // Assert
            Assert.AreEqual(1000, result, "Lors de l'initialisation un drone doit avoir une charge de 1000");
        
        }

        [TestMethod]
        public void UpdateDroneTest2()
        {
            // Arrange
            Drone testDrone = new Drone(100, 100, "test");
            int oldCharge = testDrone.charge = 0;

            // Act
            testDrone.Update(1);
            int result = testDrone.charge;

            // Assert
            Assert.IsTrue(result == oldCharge);


        }

        [TestMethod]
        public void Test_that_drone_is_taking_orders()
        {
            // Arrange
            Drone drone = new Drone(500, 500);

            // Act
            EvacuationState state = drone.GetEvacuationState();

            // Assert
            Assert.AreEqual(EvacuationState.Free, state);

            // Arrange a no-fly zone around the drone
            bool response = drone.Evacuate(new System.Drawing.Rectangle(400, 400, 200, 200));

            // Assert
            Assert.IsFalse(response); // because the zone is around the drone
            Assert.AreEqual(EvacuationState.Evacuating, drone.GetEvacuationState());

            // Arrange: remove no-fly zone
            drone.FreeFlight();

            // Assert
            Assert.AreEqual(EvacuationState.Free, drone.GetEvacuationState());
        }
    }


}
