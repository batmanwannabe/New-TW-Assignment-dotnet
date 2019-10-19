namespace TW_Assignment.Source.exceptions
{

    public class ServiceResponse
    {
        private readonly ServiceRequestException _serviceRequestException;

        public ServiceResponse(ServiceRequestException serviceRequestException)
        {
            _serviceRequestException = serviceRequestException;
        }

        public int ErrorCode
        {
            get { return _serviceRequestException.ServiceError.ErrorCode; }
        }
    }

}
