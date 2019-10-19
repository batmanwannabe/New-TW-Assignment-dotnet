using Microsoft.VisualStudio.TestTools.UnitTesting;
using TW_Assignment.Source.ExpressionValidator;

/**
 * Test for @{@link ExpressionValidator}
 * Problem statement : Validate balanced parantheses in an expression
 * For example, the expression '{[]}'' is valid whereas the expression ']]{}' is invalid.
 *
 * A correct implementation will pass all the tests.
 */

namespace Test.Source.ExpressionValidatorTest
{
    [TestClass]
    public class ExpressionValidatorTest
    {
        [TestMethod]
        public void ShouldValidateExpressionAsValid()
        {
            Assert.AreEqual(true, ExpressionValidator.Validate("{{[[(())]]}}"));
        }

        [TestMethod]
        public void ShouldValidateExpressionAsInValid()
        {
           // Assert.AreEqual(false, ExpressionValidator.Validate("{{[[(())]]}}("));
            Assert.AreEqual(false, ExpressionValidator.Validate("}{"));
        }
    }
}
