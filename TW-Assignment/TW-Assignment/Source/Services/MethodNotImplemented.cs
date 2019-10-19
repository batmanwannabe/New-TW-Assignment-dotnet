using System;

namespace TW_Assignment.Source.exceptions
{
    public class MethodNotImplementedException : SystemException
    {
        public MethodNotImplementedException(String methodName) : base("Method: " + methodName + " is not implemented") { }
    }

}
