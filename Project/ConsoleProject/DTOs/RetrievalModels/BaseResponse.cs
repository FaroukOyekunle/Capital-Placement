using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.DTOs.RetrievalModels
{
    // BaseResponse<T> represents the generic data transfer object (DTO) for response data.
    public class BaseResponse<T>
    {
        // Data property holds the generic data returned in the response.
        public T Data { get; set; }

        // Status property indicates the status of the response (e.g., success or failure).
        public bool Status { get; set; }

        // Message property provides an optional message or description related to the response.
        public string Message { get; set; }
    }
}
