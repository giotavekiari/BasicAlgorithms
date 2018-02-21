﻿using BasicAlgorithms.Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms.Tests.Practice
{
    [TestClass]
    public class VariousProblemsTests
    {


        [TestMethod]
        public void FindCharacterBinary()
        {
            var problems = new VariousProblems();

            Assert.AreEqual(1, problems.FindCharacterBinary(5, 5, 3));
            Assert.AreEqual(1, problems.FindCharacterBinary(11, 6, 4));
        }


        [TestMethod]
        public void MaximumTipCalculator()
        {
            var problems = new VariousProblems();

            var orders = new List<int> { 5, 3, 3 };
            var tipsA = new List<int> { 1, 2, 3, 4, 5 };
            var tipsB = new List<int> { 5, 4, 3, 2, 1 };
            Assert.AreEqual(21, problems.MaximumTipCalculator(orders, tipsA, tipsB));

            orders = new List<int> { 8, 4, 4 };
            tipsA = new List<int> { 1, 4, 3, 2, 7, 5, 9, 6 };
            tipsB = new List<int> { 1, 2, 3, 6, 5, 4, 9, 8 };
            Assert.AreEqual(43, problems.MaximumTipCalculator(orders, tipsA, tipsB));
        }

        [TestMethod]
        public void ArrayContiguousIntegers()
        {
            var problems = new VariousProblems();
            var list = new List<int> { 5, 2, 3, 6, 4, 4, 6, 6 };
            Assert.IsTrue(problems.ArrayContiguousIntegers(list));//2,3,4,5,6

            list = new List<int> { 10, 14, 10, 12, 12, 13, 15 };
            Assert.IsFalse(problems.ArrayContiguousIntegers(list));//no continous numbers
        }

        [TestMethod]
        public void OrderByAbsoluteOrder()
        {
            var problems = new VariousProblems();

            var list = new List<int> { 1, -3, 2, 3, 6, -1 };
            var result = problems.OrderByAbsoluteOrder(list);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(-3, result[2]);
            Assert.AreEqual(3, result[3]);

            list = new List<int> { 4, 8, 9, -4, 1, -1, -8, -9 };
            result = problems.OrderByAbsoluteOrder(list);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(-4, result[2]);
            Assert.AreEqual(4, result[3]);
            Assert.AreEqual(-8, result[4]);
            Assert.AreEqual(8, result[5]);
            Assert.AreEqual(-9, result[6]);
            Assert.AreEqual(9, result[7]);
        }
    }
}
