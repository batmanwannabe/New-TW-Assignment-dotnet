using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TW_Assignment.Source.findClassName;

/**
 * Test for @{@link ClassIdentifierImpl}
 *
 * You are a hacker! And you wanted to tear apart enemy software system. only if we could find out the name the
 * class being used.You do not have access to their source code or binaries.
 * A mole will drop your binaries into the system and that is the only opportunity you have !
 */

namespace Test.Source.findClassName
{
    [TestClass]
    //Should return the class name of the given inputs.
    public class ClassIdentifierImplTest
    {
        [TestMethod]
        public void ShouldReturnClassNameOfIntegerIfBothParametersAreIntegers()
        {
            IClassIdentifier<Int32, Int32> identifier = new ClassIdentifierImpl<Int32, Int32>();
            String[] expectedTypes = new String[] { "Int32", "Int32" };
            int one = 1;
            int two = 2;
            CollectionAssert.AreEqual(expectedTypes, identifier.IdentifyClasses(one, two));
        }

        [TestMethod]
        public void ShouldReturnClassNameOfIntegerAndString()
        {
            IClassIdentifier<Int32, String> identifier = new ClassIdentifierImpl<Int32, String>();
            String[] expectedTypes = new String[] { "Int32", "String" };
            int one = 1;
            CollectionAssert.AreEqual(expectedTypes, identifier.IdentifyClasses(one, "pie"));
        }

        [TestMethod]
        public void ShouldReturnClassNameOfAnimalAndString()
        {
            IClassIdentifier<Animal, String> identifier = new ClassIdentifierImpl<Animal, String>();
            String[] expectedTypes = new String[] { "Animal", "String" };
            Animal animal = new Animal();
            CollectionAssert.AreEqual(expectedTypes, identifier.IdentifyClasses(animal, "pie"));
        }
    }
}
