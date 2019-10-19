using System;

namespace TW_Assignment.Source.exceptions
{
    public class Bing : IErraticService
    {
        private readonly ErraticService _service;

        public Bing(ErraticService service)
        {
            _service = service;
        }

        public ServiceResponse Search(string query)
        {
            try
            {
                var serviceResponse = _service.Search(query);
                return serviceResponse;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            
        }
    }
}