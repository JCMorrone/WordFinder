using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WordFinderChallenge;

namespace MatrixTests
{
    [TestClass]
    public class WordFinderTests
    {
        [TestMethod]
        public void TestWordFindingWorks()
        {
            //Arrange
            var sourceMatrix = new List<string>
            {
                "estt",
                "test",
                "test",
            };

            var inputWords = new List<string>
            {
                "test",
                "est",
                "ett",
                "s",
                "s",
            };

            var outputWords = new List<string>
            {
                "s",
                "est",
                "test",
                "ett"
            };

            var wordFinder = new WordFinder(sourceMatrix);

            //Act
            var result = wordFinder.Find(inputWords);

            //Assert
            Assert.IsTrue(result.SequenceEqual(outputWords));
        }

        [TestMethod]
        public void TestWordFindingReturnsNothingOnInvalidWord()
        {
            //Arrange
            var sourceMatrix = new List<string>
            {
                "estt",
                "test",
                "test",
            };

            var inputWords = new List<string>
            {
                "x",
                "z",
            };

            var outputWords = new List<string>
            {
            };

            var wordFinder = new WordFinder(sourceMatrix);

            //Act
            var result = wordFinder.Find(inputWords);

            //Assert
            Assert.IsTrue(result.SequenceEqual(outputWords));
        }
    }
}
