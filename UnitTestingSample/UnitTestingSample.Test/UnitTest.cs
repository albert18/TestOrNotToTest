using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingSample.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [TestCategory("Test Or Not To Test")]
        [Owner("John Doe")]
        public void DinnerTime_Return()
        {
            //Arrage
            int currentResult = 1;

            //Act
            DinnerTime aa = new DinnerTime();
            var expectedResult = aa.TimeToEat();

            //Assert
            Assert.IsTrue(expectedResult.Length > currentResult);
        }
    }
}
