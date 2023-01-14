using RównaniaKwadratowe_Model;

namespace RównaniaKwadratowe_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RozwiązywaczRównańKwadratowych rrk = new RozwiązywaczRównańKwadratowych(1, 2, 1);
            Assert.AreEqual(-1, rrk.X1);
            Assert.AreEqual(-1, rrk.X2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            RozwiązywaczRównańKwadratowych rrk = new RozwiązywaczRównańKwadratowych(1, -2, 1);
            Assert.AreEqual(1, rrk.X1);
            Assert.AreEqual(1, rrk.X2);
        }

        [TestMethod]
        public void TestMethod3()
        {
            RozwiązywaczRównańKwadratowych rrk = new RozwiązywaczRównańKwadratowych(1, 0, -1);
            Assert.AreEqual(-1, rrk.X1);
            Assert.AreEqual(1, rrk.X2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod4()
        {
            RozwiązywaczRównańKwadratowych rrk = new RozwiązywaczRównańKwadratowych(0, 1, 1);
        }
    }
}