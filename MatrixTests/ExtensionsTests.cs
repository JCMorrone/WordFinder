using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using WordFinderChallenge.Extensions;

namespace MatrixTests
{
    [TestClass]
    public class ExtensionsTests
    {
        [TestMethod]
        public void TestPivotWorks()
        {
            //Arrange
            var sourceMatrix = new List<string>
            {
                "estt",
                "test",
                "test"
            };

            var resultMatrix = new List<string>
            {
                "ett",
                "see",
                "tss",
                "ttt"
            };

            //Act
            var result = sourceMatrix.Pivot().Select(x => string.Concat(x));


            //Assert
            Assert.IsTrue(result.SequenceEqual(resultMatrix));
        }
    }
}
