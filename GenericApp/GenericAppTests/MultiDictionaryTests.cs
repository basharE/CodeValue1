using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericApp.Tests
{
    [TestClass()]
    public class MultiDictionaryTests
    {
        [TestMethod()]
        public void AddTest()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            int NumOfElements = aDictionary.Count;
            aDictionary.Add(1, "w");
            Assert.AreEqual(NumOfElements + 1,aDictionary.Count);
        }

        [TestMethod()]
        public void AddTestZero()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            int NumOfElements = aDictionary.Count;
            aDictionary.Add(0, "w");
            Assert.AreEqual(NumOfElements + 1, aDictionary.Count);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddTestNullValue()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();           
            aDictionary.Add(0, null);            
        }

        [TestMethod()]
        public void AddTestWthExistKey()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            int NumOfElements = aDictionary.Count;
            aDictionary.Add(1, "w");
            aDictionary.Add(1, "e");
            Assert.AreEqual(NumOfElements + 2, aDictionary.Count);
        }

        [TestMethod()]
        public void AddTestWthNotExistKey()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            int NumOfElements = aDictionary.Count;
            aDictionary.Add(1, "w");
            aDictionary.Add(2, "e");
            Assert.AreEqual(NumOfElements + 2, aDictionary.Count);
        }

        [TestMethod()]
        public void AddTestWthExistKeyExistvalue()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            int NumOfElements = aDictionary.Count;
            aDictionary.Add(1, "w");
            aDictionary.Add(1, "w");
            Assert.AreEqual(NumOfElements + 1, aDictionary.Count);
        }

        [TestMethod()]
        public void RemoveTestExistKey()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            aDictionary.Add(1, "w");
            int numOfElements = aDictionary.Count;
            aDictionary.Remove(1);
            Assert.AreEqual(numOfElements -1, aDictionary.Count);
        }

        [TestMethod()]
        public void RemoveTestNotExistKey()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();           
            
            Assert.IsFalse(aDictionary.Remove(1));
        }

 
        [TestMethod()]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void RemoveTestExistValue()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            aDictionary.Add(1, "w");
            aDictionary.Remove(2,"w");
            
        }

        [TestMethod()]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void RemoveTestNExistValue()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();

            aDictionary.Remove(1,"w");
        }

        [TestMethod()]
        public void RemoveTestExistKeyV()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            aDictionary.Add(1, "w");
            Assert.IsFalse(aDictionary.Remove(1, "r"));
        }

        [TestMethod()]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void RemoveTestNotExistKeyV()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            aDictionary.Add(2, "w");
            aDictionary.Remove(1, "r");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemoveTestNullValue()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            aDictionary.Remove(1, null);
        }

        [TestMethod()]
        public void ClearTestEmpty()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            int NoElemente = 0;
            aDictionary.Clear();
            Assert.AreEqual(NoElemente,aDictionary.Count);
        }

        [TestMethod()]
        public void ClearTestNotEmpty()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            aDictionary.Add(2, "w");
            aDictionary.Clear();
            Assert.AreEqual(0, aDictionary.Count);
        }

        [TestMethod()]
        public void ContainsKey()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            aDictionary.Add(2, "w");
            Assert.IsTrue(aDictionary.ContainsKey(2));
        }

        [TestMethod()]
        public void ContainsNotKey()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            Assert.IsFalse(aDictionary.ContainsKey(2));
        }

        [TestMethod()]
        public void ContainsKeyValue()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            aDictionary.Add(2, "w");
            Assert.IsTrue(aDictionary.Contains(2,"w"));
        }

        [TestMethod()]
        public void ContainsNotKeyValue()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            aDictionary.Add(1, "w");
            Assert.IsFalse(aDictionary.Contains(2, "w"));
        }

        [TestMethod()]
        public void ContainsNotKeyNotValue()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            aDictionary.Add(1, "w");
            Assert.IsFalse(aDictionary.Contains(2, "o"));
        }

        [TestMethod()]
        public void ContainsKeyNotValue()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            aDictionary.Add(1, "w");
            Assert.IsFalse(aDictionary.Contains(1, "o"));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ContainsNullValue()
        {
            MultiDictionary<int, string> aDictionary = new MultiDictionary<int, string>();
            aDictionary.Contains(1, null);
        }
    }
}