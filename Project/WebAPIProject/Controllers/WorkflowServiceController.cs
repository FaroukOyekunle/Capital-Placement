using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ConsoleProject.DTOs.RequestModels;
using ConsoleProject.DTOs.RequestModels.Stage;
using ConsoleProject.DTOs.RetrievalModels;
using WebAPIProject.Interfaces.Services;

namespace WebAPIProject.Controllers
{
    // Mark the controller as an API controller.
    [ApiController]
    // Define the route for the controller.
    [Route("api/[controller]")]
    public class WorkflowServiceController : ControllerBase
    {
        // Private field to store the workflow service.
        private readonly IWorkflowService _workflowService;

        // Constructor injection for the service interface.
        public WorkflowServiceController(IWorkflowService workflowService)
        {
            _workflowService = workflowService;
        }

        // Define the HTTP route for creating a new stage.
        [HttpPost]
        public async Task<IActionResult> CreateStageAsync(CreateStage stageRequestModel)
        {
            // Call the service method to create a new stage and get the response.
            var response = await _workflowService.CreateStageAsync(stageRequestModel);
            // Check if the operation was successful and return the appropriate result.
            // If successful, return the response as Ok result, otherwise return a BadRequest with the error message.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for getting a stage by its Id.
        [HttpGet]
        public async Task<IActionResult> GetStageAsync(string Id)
        {
            // Call the service method to get the stage details by its Id and get the response.
            var response = await _workflowService.GetStageAsync(Id);
            // Check if the operation was successful and return the appropriate result.
            // If successful, return the response as Ok result, otherwise return a BadRequest with the error message.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for getting all stages.
        [HttpGet]
        public async Task<IActionResult> GetStagesAsync()
        {
            // Call the service method to get all stages and get the response.
            var response = await _workflowService.GetStagesAsync();
            // Check if the operation was successful and return the appropriate result.
            // If successful, return the response as Ok result, otherwise return a BadRequest with the error message.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for updating a usual stage by its stage name.
        [HttpPut]
        public async Task<IActionResult> UpdateUsualStageAsync([FromBody] UpdateUsualStage updateUsualStage, [FromQuery] string stageName)
        {
            // Call the service method to update the usual stage and get the response.
            var response = await _workflowService.UpdateUsualStageAsync(updateUsualStage, stageName);
            // Check if the operation was successful and return the appropriate result.
            // If successful, return the response as Ok result, otherwise return a BadRequest with the error message.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for updating a video interview stage by its stage name.
        [HttpPut]
        public async Task<IActionResult> UpdateVideoInterviewStageAsync([FromBody] UpdateVideoInterviewStage updateVideoInterviewStage, [FromQuery] string stageName)
        {
            // Call the service method to update the video interview stage and get the response.
            var response = await _workflowService.UpdateVideoInterviewStageAsync(updateVideoInterviewStage, stageName);
            // Check if the operation was successful and return the appropriate result.
            // If successful, return the response as Ok result, otherwise return a BadRequest with the error message.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for deleting a stage by its Id.
        [HttpDelete]
        public async Task<IActionResult> DeleteStageAsync([FromQuery] string id)
        {
            // Call the service method to delete the stage and get the response.
            var response = await _workflowService.DeleteStageAsync(id);
            // Check if the operation was successful and return the appropriate result.
            // If successful, return the response as Ok result, otherwise return a BadRequest with the error message.
            return response.Status ? Ok(response) : BadRequest(response);
        }
    }
}
