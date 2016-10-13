using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace codilityTest.tdd
{
    [TestClass]
    public class missingnumTest
    {
        [TestMethod]
        public void TestMissingNumbers()
        {
            var sut = new utilities();
             List<int> testList= new List<int>() { 1,4,6};
            List<int> ExpectedList = new List<int>() { 2,3,5 };

            List<int> Result = sut.GetMissingNums(testList);
            Assert.AreEqual(ExpectedList.Count, Result.Count);
            Assert.IsTrue(areEqualList(ExpectedList,Result));
             
        }

        private bool areEqualList(List<int> src, List<int> dest)
        {
            bool AreEqual = false;
            for (var temp = 0; temp < src.Count; temp++)
            {
                AreEqual = (src[temp] == dest[temp]) ? true : false;
                
            }
            return AreEqual;
        }

    }
}
