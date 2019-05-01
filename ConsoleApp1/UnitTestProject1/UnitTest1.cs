using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SuccessTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void FailTest()
        {
            Assert.IsTrue(false);
        }
    }
}
