using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

namespace Recursion
{
    [TestFixture]
    public class PowerSetTests
    {
        private int[][] result;

        [OneTimeSetUp]
        public void Init()
        {
            result = null;
        }

        [Test]
        public void powerSetSetWithOneElement()
        {
            Recursion.powerSet(new int[] {1}, 0, out result);
            int[][] expected = {new int[] {1}};
            Assert.AreEqual(result, expected);
        }

        // [Test]
        // public void powerSetSetWithTwoElements()
        // {
        //     Recursion.powerSet(new int[] {1, 2}, 0, out result);
        //     int[][] expected = {new int[] {1, 2}, new int[] {1}};
        //     Assert.IsTrue(true);
        // }

        // [Test]
        // public void powerSetSetWithFourElements()
        // {
        //     Recursion.powerSet(new int[] {1});
        //     Assert.IsTrue(true);
        // }

        // [Test]
        // public void powerSetSetWithSevenElements()
        // {
        //     Recursion.powerSet(new int[] {1});
        //     Assert.IsTrue(true);
        // }
        // [Test]
        // public void powerSetNullInput()
        // {
        //     Assert.IsTrue(true);
        // }

        // [Test]
        // public void powerSetEmptySet()
        // {
        //     Assert.IsTrue(true);
        // }
    }

    [TestFixture]
    public class TripleStepsTest
    {
        [Test]
        public void TripleStepsWithOne()
        {
            int result = Recursion.tripleStep(1);
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void TripleStepsWithTwo()
        {
            int result = Recursion.tripleStep(2);
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void TripleStepsWithThree()
        {
            int result = Recursion.tripleStep(3);
            Assert.AreEqual(result, 4);
        }

        [Test]
        public void TripleStepsWithFour()
        {
            int result = Recursion.tripleStep(4);
            Assert.AreEqual(result, 8);
        }
    }

    [TestFixture]
    public class PermsWithOutDupsTest
    {
        [Test]
        public void PermsWithOutDupsSingleString()
        {
            var result = Recursion.permsWithOutDups("A");
            var expected = new List<string>(new string[] {"A"});
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void PermsWithOutDupsTwotrings()
        {
            var result = Recursion.permsWithOutDups("AB");
            var expected = new List<string>(new string[] {"AB", "BA"});
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void PermsWithOutDupsThreeStrings()
        {
            var result = Recursion.permsWithOutDups("ABC");
            var expected = new List<string>(new string[] {"ABC", "BAC", "BCA", "ACB", "CAB", "CBA"});
            Assert.AreEqual(result, expected);
        }
    }

    [TestFixture]
    public class PermsWithDupsTest
    {
        // confirm that all contents are unique
        // confirm the correct number of permutations are returned:
        // e.g. for "AABBC" => (5 * 4 / 2) * (3 * 2 / 2) * 1 = 30
        [Test]
        public void PermsWithNoDups()
        {
            var result = Recursion.permsWithDups("ABC");
            var expectedCount = 3 * 2 * 1;
            Assert.AreEqual(result.Count, expectedCount);
            Assert.AreEqual(result.Count, result.Distinct().Count());
        }

        [Test]
        public void PermsWithOneDupOneCharater()
        {
            var result = Recursion.permsWithDups("AABC");
            var expectedCount = (4 * 3 / 2) * 2 * 1;
            Assert.AreEqual(result.Count, expectedCount);
            Assert.AreEqual(result.Count, result.Distinct().Count());
        }

        [Test]
        public void PermsWithTwoDupsTwoCharacters()
        {
            var result = Recursion.permsWithDups("AABBC");
            var expectedCount = (5 * 4 / 2) *(3 * 2 / 2) * 1;
            Assert.AreEqual(result.Count, expectedCount);
            Assert.AreEqual(result.Count, result.Distinct().Count());
        }

        [Test]
        public void PermsWithThreeDupsOneCharacter()
        {
            var result = Recursion.permsWithDups("AAABC");
            var expectedCount = (5 * 4 * 3 / (3 * 2)) * 2 * 1;
            Assert.AreEqual(result.Count, expectedCount);
            Assert.AreEqual(result.Count, result.Distinct().Count());
        }
    }

}