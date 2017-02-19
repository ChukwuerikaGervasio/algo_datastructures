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

        // [Test]
        // public void PermsWithOutDupsInt()
        // {
        //     var result = Recursion.permsWithOutDups(1);
        //     var expected = new List<string>(new string[] {});
        //     Assert.AreEqual(result, expected);
        // }

        // [Test]
        // public void PermsWithOutDupsNull()
        // {
        //     var result = Recursion.permsWithOutDups(null);
        //     var expected = new List<string>(new string[] {});
        //     Assert.AreEqual(result, expected);
        // }

        // public void PermsWithOutDupsEmpty()
        // {
        //     var result = Recursion.permsWithOutDups("");
        //     var expected = new List<string>(new string[] {});
        //     Assert.AreEqual(result, expected);
        // }
    }
}