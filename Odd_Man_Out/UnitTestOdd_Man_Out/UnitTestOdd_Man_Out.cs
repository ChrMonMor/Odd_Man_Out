using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Odd_Man_Out;

namespace UnitTestOdd_Man_Out
{
    [TestClass]
    public class UnitTestOdd_Man_Out
    {
        [TestMethod]
        public void TestMethodFindsOddManOut()
        {
            //-- Arrange
            int[] vs = { 21, 1, 3, 17, 1, 5, 15, 7, 5, 9, 9, 11, 13, 13, 15, 17, 21, 3  }; 
            int expecte = 7;

            //-- Act
            var actual = Program.FindsOddManOut(vs);

            //-- Assert
            Assert.AreEqual(expecte, actual);
        }
        [TestMethod]
        public void TestMethodFindsOddManOutTest2()
        {
            //-- Arrange
            int[] vs = { 9, 3, 9, 3, 9, 7, 9 };
            int expecte = 7;

            //-- Act
            var actual = Program.FindsOddManOut(vs);

            //-- Assert
            Assert.AreEqual(expecte, actual);
        }
    }
}
