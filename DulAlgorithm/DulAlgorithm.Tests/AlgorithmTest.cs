using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DulAlgorithm.Tests
{
    [TestClass]
    public class AlgorithmClassTest
    {
        
        [TestMethod]
        public void SelectionSortMethodTest()
        {
            //[1] Arrange(정렬), Setup
            int[] arr = { 33, 22, 44 };

            //[2] Act(동작), Execute
            int[] results = DulAlgorithm.Algorithm.SelectionSort(arr);

            //[3] Assert(어설션), Verify
            Assert.AreEqual(22, results[0]); //기대값, 실제값
            Assert.AreEqual(44, results[results.Length - 1]);

        }
    }
}
