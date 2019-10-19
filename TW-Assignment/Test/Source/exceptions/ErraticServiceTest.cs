using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TW_Assignment.Source.exceptions;

/**
 * Test for @{@link ErraticService}
 * Problem statement : Handle search exception in given Google and Bing services appropriately to make all tests pass.
 *
 */

namespace Test.Source.exceptions
{
    [TestClass]
    //Should return the correct ServiceResponse
    public class ErraticServiceTest
    {
        [TestMethod]
        public void ShouldReturnErrorCodeInCaseOfException()
        {
            var erraticService = new ErraticService();
            IErraticService erraticServiceTest = new Google(erraticService);
            ServiceResponse serviceResponse = erraticServiceTest.Search("test");
            var serviceRequestException = erraticService.LastThrownException();
            Assert.AreEqual(serviceResponse.ErrorCode, serviceRequestException.ServiceError.ErrorCode);
        }

        [TestMethod]
        public void ShouldPreserveStackTrace()
        {
            IErraticService erraticServiceTest = new Bing(new ErraticService());
            try
            {
                erraticServiceTest.Search("test");
            }
            catch (Exception exception)
            {
                var exceptionSource = exception.TargetSite;
                var source = exceptionSource.DeclaringType.Name;
                Assert.AreEqual("ErraticService", source);
            }
        }
    }

}
