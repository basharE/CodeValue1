using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strings;

namespace StringsTests
{
    [TestClass()]
    public class ProgramTests
    {
        
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void ReverseStringTestNull()
        {
            Program.ReverseString(null);
        }

        [TestMethod()]
        public void ReverseStringTestOdd()
        {
            Assert.AreEqual(Program.ReverseString("a b c"),"c b a");
        }

        [TestMethod()]
        public void ReverseStringTestEven()
        {
            Assert.AreEqual(Program.ReverseString("b c"), "c b");
        }

        [TestMethod()]
        public void GetSenTestEmpty()
        {
            Assert.AreEqual(false,Program.GetSen(""));
        }

        [TestMethod()]
        public void GetSenTestRe()
        {
            Assert.AreEqual(true, Program.GetSen("a"));
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void DisplyArrTestNull()
        {
            Program.DisplyArr(null);
        }

        [TestMethod()]
        public void DisplyArrTestOdd()
        {
            string[] input = new[] { "panther", "cat", "dog", "tiger" };
            List<string> a = new List<string>() { "rehtnap", "tac", "god", "regit" };
            Assert.IsTrue(HelpTestDisplyArr(Program.DisplyArr(input), a));
        }

        [TestMethod()]
        public void DisplyArrTestEven()
        {
            string[] input = new[] { "panther" };
            List<string> a = new List<string>() { "rehtnap" };
            Assert.IsTrue(HelpTestDisplyArr(Program.DisplyArr(input), a));
        }
        

        [TestMethod()]
        public void SortDisplyTestEven()
        {
            string[] arr = new string[]{"panther","cat","dog","tiger"};
            Assert.IsTrue(HelpTestSortDisply(Program.SortDisply(arr), new[] {"cat","dog","panther","tiger"}));

        }

        [TestMethod()]
        public void SortDisplyTestOdd()
        {
            string[] arr = new string[] { "panther", "dog", "cat" };
            Assert.IsTrue(HelpTestSortDisply(Program.SortDisply(arr), new[] { "cat", "dog", "panther" }));

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SortDisplyTestNull()
        {          
            Program.SortDisply(null);

        }

        public bool HelpTestSortDisply(string[] st1, string[] st2)
        {
            if (st1.Length != st2.Length)
                return false;
            else
            {
                for (int i = 0; i < st1.Length; i++)
                {
                    if (st1[i] != st2[i])
                        return false;
                }
                return true;
            }
        }

        public bool HelpTestDisplyArr(List<string> l1, List<string> l2)
        {
            if (l1.Count != l2.Count)
                return false;
            else
            {
                for (int i = 0; i < l2.Count; i++)
                {
                    if (!l1[i].Equals(l2[i]))
                        return false;
                }
                return true;
            }
        }
    }
}