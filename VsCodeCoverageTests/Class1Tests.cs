using Microsoft.VisualStudio.TestTools.UnitTesting;
using VsCodeCoverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsCodeCoverage.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void SumTest()
        {
            Class1 cl1 = new Class1();
            Assert.AreEqual(5, cl1.Sum(3, 2));
        }
    }
}