using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CheckOpTestNull()
        {
            Assert.IsFalse(Program.CheckOp(1, 3,null));
        }

        [TestMethod()]
        public void CheckOpTestPlus()
        {
            Assert.IsTrue(Program.CheckOp(0, 0, "+"));
        }

        [TestMethod()]
        public void CheckOpTestDivid()
        {
            Assert.IsTrue(Program.CheckOp(4, -1, "/"));
        }

        [TestMethod()]
        public void CheckOpTestMin()
        {
            Assert.IsTrue(Program.CheckOp(1, 3, "-"));
        }

        [TestMethod()]
        public void CheckOpTestMul()
        {
            Assert.IsTrue(Program.CheckOp(1, 3, "*"));
        }

        [TestMethod()]     
        public void CalcTestPlusZero()
        {
            double x = 0;
            Assert.AreEqual(Program.Calc(0,0,"+"),x);
        }

        [TestMethod()]
        public void CalcTestMinZero()
        {
            double x = 0;
            Assert.AreEqual(Program.Calc(0, 0, "-"), x);
        }

        [TestMethod()]
        public void CalcTestMulZero()
        {
            double x = 0;
            Assert.AreEqual(Program.Calc(0, 0, "*"), x);
        }

        [TestMethod()]
        public void CalcTestDivZero()
        {
            Assert.AreEqual(Program.Calc(1, 0, "/"), double.PositiveInfinity);
        }

        [TestMethod()]
        public void CalcTestMulMinNum()
        {
            Assert.AreEqual(Program.Calc(-1, -1, "*"), 1);
        }

        [TestMethod()]
        public void CalcTestPlusMinNum()
        {
            Assert.AreEqual(Program.Calc(-1, -1, "+"), -2);
        }

        [TestMethod()]
        public void CalcTestMinMinNum()
        {
            Assert.AreEqual(Program.Calc(-1, -1, "-"), 0);
        }

        [TestMethod()]
        public void CalcTestDivMinNum()
        {
            Assert.AreEqual(Program.Calc(-1, -1, "/"), 1);
        }
    }
}