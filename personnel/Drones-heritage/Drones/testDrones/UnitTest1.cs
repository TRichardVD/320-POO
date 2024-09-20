using Drones;

namespace testDrones

{
    [TestClass]
    public class UnitTest1 : PageTest
    {
        [TestMethod]
        public void MathTest()
        {
            int result = 1 + 1;

            Assert.AreEqual(2, result, "Le resultat doit etre 2");
        }
    }


}
