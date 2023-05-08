using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ConsoleProject.DTOs.RequestModels;
using ConsoleProject.DTOs.RequestModels.Stage;
using ConsoleProject.DTOs.RetrievalModels;
using WebAPIProject.Interfaces.Services;

namespace WebAPIProject.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WorkflowServiceController : ControllerBase
{
  private readonly IWorkflowService _workflowService;

    public WorkflowServiceController(IWorkflowService workflowService)
    {
        _workflowService = workflowService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateStageAsync(CreateStage stageRequestModel)
    {
      var response = await _workflowService.CreateStageAsync(stageRequestModel);
      return response.Status? Ok(response) : BadRequest(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetStageAsync(string Id)
    {
      var response = await _workflowService.GetStageAsync(Id);
      return response.Status? Ok(response) : BadRequest(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetStagesAsync()
    {
      var response = await _workflowService.GetStagesAsync();
      return response.Status? Ok(response) : BadRequest(response);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateUsualStageAsync([FromBody] UpdateUsualStage updateUsualStage, [FromQuery] string stageName)
    {
      var response = await _workflowService.UpdateUsualStageAsync(updateUsualStage,stageName);
      return response.Status? Ok(response) : BadRequest(response);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateVideoInterviewStageAsync([FromBody] UpdateVideoInterviewStage updateUsualStage, [FromQuery] string stageName)
    {
      var response = await _workflowService.UpdateVideoInterviewStageAsync(updateUsualStage,stageName);
      return response.Status? Ok(response) : BadRequest(response);
    }
    
    [HttpDelete]
    public async Task<IActionResult> DeleteStageAsync([FromQuery] string id)
    {
      var response = await _workflowService.DeleteStageAsync(id);
      return response.Status? Ok(response) : BadRequest(response);
    }
}
