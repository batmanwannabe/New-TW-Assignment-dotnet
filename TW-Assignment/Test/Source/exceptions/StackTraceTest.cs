using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TW_Assignment.Source.exceptions;

/**
 * Test for @{@link StackTraceImpl}
 * Problem statement : Report invoked method as origin of exception instead of actual origin of exception.
 *
 * A correct implementation will pass all the tests.
 */

namespace Test.Source.exceptions
{
    [TestClass]
    public class StackTraceTest
    {
        [TestMethod]
        public void ShouldClearInheritedExceptionStackTrace()
        {
            IStackTrace stacktrace = new StackTraceImpl();
            try
            {
                stacktrace.ClearStackTrace();
            }
            catch (Exception e)
            {
                Assert.AreEqual("ClearStackTrace", e.TargetSite.Name);
            }
        }
    }
}
