using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] 
        public void SuccessTest()
        {
            //adding a new line
            //adding another line
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void FailTest()
        {
            //ensure that this test fails
            Assert.IsTrue(true);
        }
    }
}
