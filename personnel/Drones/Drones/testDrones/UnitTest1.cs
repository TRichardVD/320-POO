using Drones;
using System.Drawing;
using System.Windows.Forms;


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

        [TestMethod]
        public void test_nbr_max_drones()
        {
            // Arrange
            List<Drone> fleet = new List<Drone>();
            bool result = false;

            // Act
            for (int i = 0; i < AirSpace.MAX_LENGTH_OF_FLEET; i++)
            {
                fleet.Add(new(100, 100));
                try
                {
                    Application.Run(new AirSpace(fleet));
                    result = true;
                }
                catch (Exception ex) 
                { 
                    Console.WriteLine(ex.ToString());
                    result = false;
                    break;
                }
            }

            // Assert
            Assert.IsTrue(result);

            // Act
            fleet.Add(new(100, 100));
            try
            {
                Application.Run(new AirSpace(fleet));
                result = true;
                Application.Exit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                result = false;
            }

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void test_id_factory()
        {
            // Arrange
            List<Factory> Factorys = new List<Factory>
            {
                new Factory(350, 122, 200, 99.9, Color.Black),
                new Factory(222, 350, 200, 99.9, Color.Black),
                new Factory(370, 1223, 200, 99.9, Color.Black),
                new Factory(256, 350, 200, 99.9, Color.Black),
                new Factory(350, 350, 200, 99.9, Color.Black),
                new Factory(234, 233, 200, 99.9, Color.Black),
                new Factory(320, 350, 200, 99.9, Color.Black),
                new Factory(276, 122, 200, 99.9, Color.Black),
                new Factory(390, 756, 200, 99.9, Color.Black),
                new Factory(298, 222, 200, 99.9, Color.Black),
                new Factory(300, 923, 200, 99.9, Color.Black)
            };

            // Act
            List<int> ids = new List<int>();
            foreach (Factory F in Factorys)
            {
                if (!ids.Contains(F.Id))
                    ids.Add(F.Id);

            // Assert
                else
                    Assert.Fail();
            }

        }
    }
}
