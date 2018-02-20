using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BasicAlgorithmsArrays.SortingAlgorithms;

namespace BasicAlgorithms.Tests.Arrays.SortingAlgorithms
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void MergeSort_Sort()
        {
            var search = new MergeSort();

            var list = new List<int>() { 5, 1, 3, 2, 4 }; ;
            var result = search.Sort(list);
            Assert.AreEqual(1, result.SortedData[0]);
            Assert.AreEqual(2, result.SortedData[1]);
            Assert.AreEqual(3, result.SortedData[2]);
            Assert.AreEqual(4, result.SortedData[3]);
            Assert.AreEqual(5, result.SortedData[4]);
        }


    }
}
