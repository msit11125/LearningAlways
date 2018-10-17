using Microsoft.VisualStudio.TestTools.UnitTesting;
using CellingSample02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellingSample02.Tests
{
    [TestClass()]
    public class CellingTests
    {
        [TestMethod()]
        public void GetResult_When_16p75_0p1_Then_16p8Test()
        {

            double value = 16.75;
            double baseValue = 0.1;
            double expected = 16.8;
            var actual = CellingSample02.Celling.GetResult(value, baseValue);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetResult_When_16p75_0p05_Then_16p75Test()
        {

            double value = 16.75;
            double baseValue = 0.005;
            double expected = 16.75;
            var actual = CellingSample02.Celling.GetResult(value, baseValue);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetResult_When_16p75_0p2_Then_16p8Test()
        {

            double value = 16.75;
            double baseValue = 0.2;
            double expected = 16.8;
            var actual = CellingSample02.Celling.GetResult(value, baseValue);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetResult_When_16p75_0p5_Then_17Test()
        {

            double value = 16.75;
            double baseValue = 0.5;
            double expected = 17
                ;
            var actual = CellingSample02.Celling.GetResult(value, baseValue);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void GetResult_when_16p75_0p3Then_16p8Test()
        {
            double value = 16.75;
            double baseValue = 0.3;
            double expected = 16.8;
            double actual = CellingSample02.Celling.GetResult(value, baseValue);
            Assert.AreEqual(expected, actual);
        }




        /// <summary>
        /// 四捨五入Test
        /// </summary>
        [TestMethod()]
        public void GetResult_RoundTest()
        {
            double value = 16.21;
            double baseValue = 0.5;
            double except = 16;
            var actual = CellingSample02.Celling.GetResult_Round(value, baseValue);
            Assert.AreEqual(except, actual);
        }
    }
}