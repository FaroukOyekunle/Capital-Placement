using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ConsoleProject.DTOs.RequestModels;
using ConsoleProject.DTOs.RetrievalModels;
using WebAPIProject.Interfaces.Services;

namespace WebAPIProject.Controllers
{
    // Mark the controller as an API controller.
    [ApiController]
    // Define the route for the controller.
    [Route("api/[controller]")]
    public class ProgramDetailsController : ControllerBase
    {
        // Private field to store the program details service.
        private readonly IProgramDetailsService _programDetailsService;

        // Constructor injection for the service interface.
        public ProgramDetailsController(IProgramDetailsService programDetailsService)
        {
            _programDetailsService = programDetailsService;
        }

        // Define the HTTP route for creating a new program.
        [HttpPost]
        public async Task<IActionResult> CreateProgramAsync([FromBody] CreateProgram programRequestModel)
        {
            // Call the service method to add a new program and get the response.
            var response = await _programDetailsService.AddProgramAsync(programRequestModel);
            // Check if the operation was successful and return the appropriate result.
            // If successful, return the response as Ok result, otherwise return a BadRequest with the error message.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for getting a program by its Id.
        [HttpGet]
        public async Task<IActionResult> GetProgramAsync([FromQuery] string Id)
        {
            // Call the service method to get the program details by its Id and get the response.
            var response = await _programDetailsService.GetProgramAsync(Id);
            // Check if the operation was successful and return the appropriate result.
            // If successful, return the response as Ok result, otherwise return a BadRequest with the error message.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for getting all programs.
        [HttpGet]
        public async Task<IActionResult> GetAllProgramsAsync()
        {
            // Call the service method to get all programs and get the response.
            var response = await _programDetailsService.GetAllProgramsAsync();
            // Check if the operation was successful and return the appropriate result.
            // If successful, return the response as Ok result, otherwise return a BadRequest with the error message.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for updating a program by its program title.
        [HttpPut]
        public async Task<IActionResult> UpdateProgramAsync([FromBody] UpdateProgram updateProgram, [FromQuery] string programTitle)
        {
            // Call the service method to update the program and get the response.
            var response = await _programDetailsService.EditProgramAsync(updateProgram, programTitle);
            // Check if the operation was successful and return the appropriate result.
            // If successful, return the response as Ok result, otherwise return a BadRequest with the error message.
            return response.Status ? Ok(response) : BadRequest(response);
        }

        // Define the HTTP route for deleting a program by its Id.
        [HttpDelete]
        public async Task<IActionResult> DeleteStageAsync([FromQuery] string id)
        {
            // Call the service method to delete the program and get the response.
            var response = await _programDetailsService.DeleteProgramAsync(id);
            // Check if the operation was successful and return the appropriate result.
            // If successful, return the response as Ok result, otherwise return a BadRequest with the error message.
            return response.Status ? Ok(response) : BadRequest(response);
        }
    }
}
