using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TW_Assignment.Source.ImmutableCollection;

/**
 * Test for @{@link ImmutableNinjas}
 * Problem statement : Create an immutable collection of Ninjas which prevents addition or removal of Ninjas.
 *
 * A correct implementation will pass all the tests.
 */

namespace Test.Source.ImmutableCollectionTest
{
    [TestClass]
    public class ImmutableNinjasTest
    {
        [TestMethod]
        public void ShouldBeAbleToCreateNinjaCollection()
        {
            var immutableNinjas = new ImmutableNinjas(new List<Ninja> { new Ninja("N1"), new Ninja("N2") });
            var immutableNinjasAll = immutableNinjas.All;
            Assert.AreEqual(2, immutableNinjasAll.Count());
            Assert.AreEqual("N1", immutableNinjasAll.Ninjas[0].Name);
            Assert.AreEqual("N2", immutableNinjasAll.Ninjas[1].Name);
        }

        [TestMethod, ExpectedException(typeof(NinjaException))]
        public void ShouldThrowExceptionWhenSomeoneTriesToAddToNinjas()
        {
            var immutableNinjas = new ImmutableNinjas(new List<Ninja> { new Ninja("N1"), new Ninja("N2") });
            var immutableNinjasAll = immutableNinjas.All;
            immutableNinjasAll.Add(new Ninja("N3"));
        }

        [TestMethod, ExpectedException(typeof(NinjaException))]
        public void ShouldThrowExceptionWhenSomeoneTriesToRemoveFromNinjas()
        {
            var immutableNinjas = new ImmutableNinjas(new List<Ninja> { new Ninja("N1"), new Ninja("N2") });
            var immutableNinjasAll = immutableNinjas.All;
            immutableNinjasAll.Remove(new Ninja("N1"));
        }

    }
}
