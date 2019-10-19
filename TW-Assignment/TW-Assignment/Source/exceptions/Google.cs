namespace TW_Assignment.Source.exceptions
{
    public class Google : IErraticService
    {
        private readonly IErraticService _service;

        public Google(IErraticService service)
        {
            _service = service;
        }
        
        public ServiceResponse Search(string query)
        {
            return _service.Search(query);
        }

    }
}
