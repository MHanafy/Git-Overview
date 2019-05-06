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
            
            // Change from Juan
        }

        [TestMethod]
        public void FailTest()
        {
            //ensure that this test fails
            Assert.IsTrue(false);
        }
    }
}
