using System;
using BinaryDisplay;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDisplayTests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CalcBTest()
        {
            int num = 127;
            int expected = 7;          
            int actual = Program.CalcB(num);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcBTestF()
        {
            int num = 128;
            int expected = 1;   
            int actual = Program.CalcB(num);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcBTestZero()
        {
            int num = 0;
            int expected = 0;
            int actual = Program.CalcB(num);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArithmeticException))]
        public void CalcBTestMin()
        {
            Program.CalcB(-1);
        }      
    }
}