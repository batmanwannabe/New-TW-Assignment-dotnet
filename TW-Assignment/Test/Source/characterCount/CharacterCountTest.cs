using System.Collections.Specialized;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TW_Assignment.Source.characterCount;


/**
 * Test for @{@link CharacterCount}
 * Problem statement : Given a string, find out the number of occurences of each charachter.
 * For eg. Given the string 'apple' , occurence of each word is as follows
 * a - 1
 * p - 2
 * l - 1
 * e - 1
 *
 * A correct implementation will pass all the tests.
 */

namespace Test.Source.characterCount
{
    [TestClass]
    public class CharacterCountTest
    {

        [TestMethod]
        public void ShouldReturnEmptyMapIfStringIsEmpty()
        {
            OrderedDictionary characterDictionary = CharacterCount.CountCharacters("");

            Assert.AreEqual(0, characterDictionary.Count);
        }

        [TestMethod]
        public void ShouldReturnCorrectCountIfStringContainsOneCharacter()
        {
            OrderedDictionary characterCount = CharacterCount.CountCharacters("T");

            Assert.AreEqual(1, characterCount["T"]);
        }

        [TestMethod]
        public void ShouldReturnCorrectCountIfStringContainsOneWord()
        {
            OrderedDictionary characterCount = CharacterCount.CountCharacters("Apple");

            Assert.AreEqual(1, characterCount["A"]);
            Assert.AreEqual(2, characterCount["p"]);
            Assert.AreEqual(1, characterCount["l"]);
            Assert.AreEqual(1, characterCount["e"]);
        }

        [TestMethod]
        public void ShouldReturnCorrectCountIfStringContainsOneSentence()
        {
            OrderedDictionary characterCount = CharacterCount.CountCharacters("Hello hari!!");

            Assert.AreEqual(1, characterCount["H"]);
            Assert.AreEqual(1, characterCount["e"]);
            Assert.AreEqual(2, characterCount["l"]);
            Assert.AreEqual(1, characterCount["o"]);
            Assert.AreEqual(1, characterCount["h"]);
            Assert.AreEqual(1, characterCount["a"]);
            Assert.AreEqual(1, characterCount["r"]);
            Assert.AreEqual(1, characterCount["i"]);
            Assert.AreEqual(2, characterCount["!"]);
        }

        [TestMethod]
        public void ShouldReturnEmptyMapIfStringContainsOnlySpaces()
        {
            OrderedDictionary characterCount = CharacterCount.CountCharacters("   ");

            Assert.AreEqual(0, characterCount.Count);
        }
    }

}