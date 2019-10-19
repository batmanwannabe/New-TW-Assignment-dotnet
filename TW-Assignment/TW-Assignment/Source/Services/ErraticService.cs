using System;
using System.Collections.Generic;

namespace TW_Assignment.Source.exceptions
{
    public class ErraticService : IErraticService
    {
        private readonly Stack<ServiceRequestException> _serviceRequestExceptions;

        public ErraticService()
        {
            _serviceRequestExceptions = new Stack<ServiceRequestException>();
        }
        
        public ServiceResponse Search(string query)
        {
            var errorCode = new Random().Next();
            var serviceRequestException = new ServiceRequestException(new ServiceError(errorCode));
            _serviceRequestExceptions.Push(serviceRequestException);
            throw serviceRequestException;
        }

        public ServiceRequestException LastThrownException()
        {
            return _serviceRequestExceptions.Pop();
        }
    }

    public class ServiceRequestException : Exception
    {
        public ServiceError ServiceError { get; private set; }

        public ServiceRequestException(ServiceError serviceError)
        {
            ServiceError = serviceError;
        }
    }

    public class ServiceError
    {
        public int ErrorCode { get; private set; }

        public ServiceError(int errorCode)
        {
            ErrorCode = errorCode;
        }
    }
}