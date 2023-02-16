using System.Collections.Generic;

namespace skinet.Errors
{
    public class ApiValidationErrorResponse : ApiResponse
    {
        public ApiValidationErrorResponse() : base(400)
        {
        }

        public IEnumerable<string> MyProperty { get; set; } 

    }
}
