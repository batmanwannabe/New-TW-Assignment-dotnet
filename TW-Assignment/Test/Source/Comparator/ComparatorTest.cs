using Microsoft.VisualStudio.TestTools.UnitTesting;
using TW_Assignment.Source.Comparator;

/**
 * Test for @{@link ComparatorImpl}
 * Problem statement : Implement a generic comparator which can compare values of given types
 *
 * A correct implementation will pass all the tests.
 */

namespace Test.Source.Comparator
{
    [TestClass]
    public class ComparatorTest
    {
        [TestMethod]
        public void ShouldGiveGreaterOfTwoIntegers()
        {
            var comparatorImpl = new ComparatorImpl<int>();
            Assert.AreEqual(10, comparatorImpl.FindGreater(5, 10));
        }

        [TestMethod]
        public void ShouldGiveGreaterOfTwoCharacters()
        {
            var comparatorImpl = new ComparatorImpl<char>();
            Assert.AreEqual('j', comparatorImpl.FindGreater('j', 'a'));
        }

        [TestMethod]
        public void ShouldGiveGreaterOfTwoFloatingPointNumbers()
        {
            var comparatorImpl = new ComparatorImpl<double>();
            Assert.AreEqual(9.885, comparatorImpl.FindGreater(9.88, 9.885));
        }

        [TestMethod]
        //Do a alphabetical string comparison.
        // for example a is lesser than b
        public void ShouldGiveGreaterOfTwoStrings()
        {
            var comparatorImpl = new ComparatorImpl<string>();
            Assert.AreEqual("ThoughtWorks", comparatorImpl.FindGreater("ThoughtWorks", "ThoughtWorked"));
        }

        [TestMethod]
        public void ShouldGiveAnyOfTwoEqualNumbers()
        {
            var comparatorImpl = new ComparatorImpl<int>();
            Assert.AreEqual(10, comparatorImpl.FindGreater(10, 10));
        }
    }
}