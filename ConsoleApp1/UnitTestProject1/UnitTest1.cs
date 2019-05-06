using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    //Deb_d1
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
            //ensure that this test fails
            Assert.IsTrue(false);
        }
    }
}
