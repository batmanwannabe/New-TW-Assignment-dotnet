using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TW_Assignment.Source.duplicateString;

/**
 * Test for @{@link UniqueList}
 * Problem statement : Get the list of unique strings from a given list of strings.
 * For example, Given the list ('apple', 'apple', 'mango'), de-duplication returns ('apple', 'mango')
 *
 * A correct implementation will pass all the tests.
 */

namespace Test.Source.duplicatestring
{
    [TestClass]
    public class UniqueListTest
    {

        [TestMethod]
        public void ShouldReturnEmptyListIfInputListIsEmpty()
        {
            List<string> duplicateList = new List<string>();
            List<string> uniqueList = UniqueList.DeDuplicate(duplicateList);

            Assert.AreEqual(0, uniqueList.Count);
        }

        [TestMethod]
        public void ShouldReturnSameListIfInputListHasOnestring()
        {
            List<string> duplicateList = new List<string> { "ThoughtWorks" };
            List<string> uniqueList = UniqueList.DeDuplicate(duplicateList);

            Assert.AreEqual(1, uniqueList.Count);
            Assert.AreEqual("ThoughtWorks", uniqueList[0]);
        }

        [TestMethod]
        public void ShouldRemoveOneDuplicatestringIfInputListHasTwoSamestrings()
        {
            List<string> duplicateList = new List<string> { "ThoughtWorks", "ThoughtWorks" };
            List<string> uniqueList = UniqueList.DeDuplicate(duplicateList);

            Assert.AreEqual(1, uniqueList.Count);
            Assert.AreEqual("ThoughtWorks", uniqueList[0]);
        }

        [TestMethod]
        public void ShouldRemoveDuplicateAndMaintainOrderInInputListsWithDuplicateElements()
        {
            List<string> duplicateList = new List<string> { "orange", "apple", "banana", "apple" };
            List<string> uniqueList = UniqueList.DeDuplicate(duplicateList);

            Assert.AreEqual(3, uniqueList.Count);
            Assert.IsTrue(uniqueList.Contains("orange"));
            Assert.IsTrue(uniqueList.Contains("apple"));
            Assert.IsTrue(uniqueList.Contains("banana"));
        }

    }

}
