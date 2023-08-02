using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ConsoleProject.DTOs.RequestModels;
using ConsoleProject.DTOs.RetrievalModels;
using WebAPIProject.Interfaces.Services;

namespace TaskProjectWebAPI.Controllers
{
    // Mark the controller as an API controller.
    [ApiController]
    // Define the route for the controller.
    [Route("api/[controller]")]
    public class ApplicationTemplateController : ControllerBase
    {
        private readonly IApplicationTemplateService _applicationTemplateService;

        // Constructor injection for the service interface.
        public ApplicationTemplateController(IApplicationTemplateService applicationTemplateService)
        {
            _applicationTemplateService = applicationTemplateService;
        }

        // Define the HTTP route for creating an application.
        [HttpPost]
        public async Task<IActionResult> CreateApplicationAsync([FromBody] CreateApplication applicationModel)
        {
            // Call the service method to create the application and get the response.
            var response = await _applicationTemplateService.CreateApplicationAsync(applicationModel);
            // Check if the operation was successful and return the appropriate result.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for getting a single application by its ID.
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetApplicationAsync(string Id)
        {
            // Call the service method to get the application and get the response.
            var response = await _applicationTemplateService.GetApplicationAsync(Id);
            // Check if the operation was successful and return the appropriate result.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for getting all applications.
        [HttpGet]
        public async Task<IActionResult> GetApplicationsAsync()
        {
            // Call the service method to get all applications and get the response.
            var response = await _applicationTemplateService.GetApplicationsAsync();
            // Check if the operation was successful and return the appropriate result.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for updating an application by its ID.
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApplicationAsync([FromBody] UpdateApplication updateApplicationModel, [FromRoute] string id)
        {
            // Call the service method to update the application and get the response.
            var response = await _applicationTemplateService.UpdateApplicationAsync(updateApplicationModel, id);
            // Check if the operation was successful and return the appropriate result.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for deleting an application by its ID.
        [HttpDelete]
        public async Task<IActionResult> DeleteApplicationAsync([FromQuery] string id)
        {
            // Call the service method to delete the application and get the response.
            var response = await _applicationTemplateService.DeleteApplicationAsync(id);
            // Check if the operation was successful and return the appropriate result.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for creating a question.
        [HttpPost("question")]
        public async Task<IActionResult> CreateQuestionAsync([FromBody] BaseQuestionRequestModel requestModel)
        {
            // Call the service method to create the question and get the response.
            var response = await _applicationTemplateService.CreateQuestionAsync(requestModel);
            // Check if the operation was successful and return the appropriate result.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for getting a single question by its ID.
        [HttpGet("question/{Id}")]
        public async Task<IActionResult> GetQuestionAsync(string Id)
        {
            // Call the service method to get the question and get the response.
            var response = await _applicationTemplateService.GetQuestionAsync(Id);
            // Check if the operation was successful and return the appropriate result.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for getting all questions.
        [HttpGet("questions")]
        public async Task<IActionResult> GetQuestionsAsync()
        {
            // Call the service method to get all questions and get the response.
            var response = await _applicationTemplateService.GetQuestionsAsync();
            // Check if the operation was successful and return the appropriate result.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for updating a question by its ID.
        [HttpPut("question/{id}")]
        public async Task<IActionResult> UpdateQuestionAsync([FromBody] UpdateQuestionModel updateQuestionModel, [FromRoute] string id)
        {
            // Call the service method to update the question and get the response.
            var response = await _applicationTemplateService.UpdateQuestionAsync(updateQuestionModel, id);
            // Check if the operation was successful and return the appropriate result.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for deleting a question by its ID.
        [HttpDelete("question")]
        public async Task<IActionResult> DeleteQuestionAsync([FromQuery] string id)
        {
            // Call the service method to delete the question and get the response.
            var response = await _applicationTemplateService.DeleteQuestionAsync(id);
            // Check if the operation was successful and return the appropriate result.
            return response.Status ? Ok(response) : BadRequest(response);
        }
    }
}
