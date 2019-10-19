using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TW_Assignment.Source.services;

namespace TW_Assignment.Source.exceptions
{
    public interface ErrorCode
    {
        ErrorCodes serviceCaller(ExceptionService stubService);
    }
}
