using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace codilityTest.tdd
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDivideBy3()
        {
            var sut = new Lib.common();
            List<int> listofvals=   sut.getDivs(0,10,3);
            Assert.AreEqual(4, listofvals.Count);

        }
        [TestMethod]
        public void TestDivideBy6()
        {
            var sut = new Lib.common();
            List<int> listofvals = sut.getDivs(0, 10, 7);
            Assert.AreEqual(2, listofvals.Count);

        }
        [TestMethod]
        public void TestDivideBy9()
        {
            var sut = new Lib.common();
            List<int> listofvals = sut.getDivs(0, 10, 9);
            Assert.AreEqual(2, listofvals.Count);

        }
        [TestMethod]
        public void TestEmptyList()
        {
            var sut = new Lib.common();
            List<int> listofvals = sut.getDivs(0, 0, -1);
            Assert.AreEqual(0, listofvals.Count);

        }
        [TestMethod]
        public void TestDivideBy3And6()
        {
            var sut = new Lib.common();
            List<int> listofvals3 = sut.getDivs(0, 10, 3);
            List<int> listofvals7 = sut.getDivs(0, 10, 7);
            List<int> commonelements = listofvals7.Intersect(listofvals3).ToList();

            Assert.AreEqual(1, commonelements.Count);

        }

         
    }
}
