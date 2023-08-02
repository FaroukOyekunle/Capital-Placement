using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAPIProject.Interfaces.Services;

namespace WebAPIProject.Controllers
{
    // Mark the controller as an API controller.
    [ApiController]
    // Define the route for the controller.
    [Route("api/[controller]")]
    public class PreviewServiceController : ControllerBase
    {
        private readonly IPreviewService _previewService;

        // Constructor injection for the service interface.
        public PreviewServiceController(IPreviewService previewService)
        {
            _previewService = previewService;
        }

        // Define the HTTP route for getting the program preview by its program title.
        [HttpGet("GetPreview")]
        public async Task<IActionResult> GetPreviewAsync([FromQuery] string programTitle)
        {
            // Call the service method to get the program preview and get the response.
            var response = await _previewService.GetProgramPreviewAsync(programTitle);
            // Check if the operation was successful and return the appropriate result.
            // If successful, return the response as Ok result, otherwise return a BadRequest with the error message.
            return response.Status ? Ok(response) : BadRequest(response.Message);
        }
    }
}
