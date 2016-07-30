using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quad.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CalcQTestTwoS()
        {            
            int expected = 2;
            int actual = Program.CalcQ(1, 5, 6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcQTestOneS()
        {
            int expected = 1;
            int actual = Program.CalcQ(1, -6, 9);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcQTestNoS()
        {
            int expected = 0;
            int actual = Program.CalcQ(3, -3, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcQTestZero()
        {
            int expected = 0;
            int actual = Program.CalcQ(0, 0, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcQTestZeroA()
        {
            int expected = 1;
            int actual = Program.CalcQ(0, 1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcQTestZeroB()
        {
            int expected = 0;
            int actual = Program.CalcQ(1, 0, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcQTestZeroC()
        {
            int expected = 2;
            int actual = Program.CalcQ(1, 1, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcQTestZeroBC()
        {
            int expected = 1;
            int actual = Program.CalcQ(1, 0, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcQTestZeroAB()
        {
            int expected = 0;
            int actual = Program.CalcQ(0, 0, 1);
            Assert.AreEqual(expected, actual);
        }
    }
}