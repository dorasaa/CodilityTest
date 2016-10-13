using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace codilityTest.tdd
{
    [TestClass]
    public class EquilibriumTest
    {
        [TestMethod]
        public void TestIfArrayIsEquilibrium()
        {
            var sut = new Lib.Equilibriam();
            int[] TestArray = {3,1,2,4,3 };
            
            Assert.AreEqual(0,sut.IsItEquilibrium(TestArray));
        }
    }
}
