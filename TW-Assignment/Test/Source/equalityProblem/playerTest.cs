using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TW_Assignment.Source.equalityProblem;

/**
 * Test for @{@link Player}
 * Problem statement : Find if two players (with properties 'name' and 'jerseyNumber') are equal.
 *
 * A correct implementation will pass all the tests.
 */

namespace Test.Source.equalityProblem
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void TwoPlayersWithSameNameAndDifferentJerseyNumbersAreNotEqual()
        {
            Player dhoni = new Player("Dhoni", 7);
            Player dhoniTwo = new Player("Dhoni", 10);
            Assert.IsFalse(dhoni.Equals(dhoniTwo));
        }

        [TestMethod]
        public void TwoPlayersWithDifferentNameAndSameJerseyNumbersAreNotEqual()
        {
            Player dhoni = new Player("Dhoni", 7);
            Player kohli = new Player("Kohli", 7);
            Assert.IsFalse(dhoni.Equals(kohli));
        }

        [TestMethod]
        public void TwoPlayersWithDifferentNameAndDifferentJerseyNumbersAreNotEqual()
        {
            Player dhoni = new Player("Dhoni", 7);
            Player kohli = new Player("Kohli", 18);
            Assert.IsFalse(dhoni.Equals(kohli));
        }

        [TestMethod]
        public void TwoPlayersWithSameNameAndJerseyNumbersAreEqual()
        {
            Player dhoni = new Player("Dhoni", 7);
            Player dhoniTwo = new Player("Dhoni", 7);
            Assert.IsTrue(dhoni.Equals(dhoniTwo));
        }

        [TestMethod]
        public void TwoEqualPlayersWhenAddedToAHashSetShouldAddOnlyOne()
        {
            var players = new HashSet<Player>();
            players.Add(new Player("Sachin", 10));
            players.Add(new Player("Sachin", 10));
            Assert.AreEqual(1, players.Count);
        }
    }
}
