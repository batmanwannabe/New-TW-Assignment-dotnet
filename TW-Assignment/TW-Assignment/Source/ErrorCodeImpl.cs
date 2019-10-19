using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW_Assignment.Source.services;

namespace TW_Assignment.Source.exceptions
{
    public class ErrorCodeImpl : ErrorCode
    {
        public ErrorCodes? serviceCaller(ExceptionService stubService)
        {
            stubService.throwException();
            return null;
        }
    }
}
