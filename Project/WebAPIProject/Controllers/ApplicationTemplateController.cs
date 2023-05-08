using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ConsoleProject.DTOs.RequestModels;
using ConsoleProject.DTOs.RetrievalModels;
using WebAPIProject.Interfaces.Services;

namespace TaskProjectWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApplicationTemplateController: ControllerBase
{
    private readonly IApplicationTemplateService _applicationTemplateService;

    public ApplicationTemplateController(IApplicationTemplateService applicationTemplateService)
    {
        _applicationTemplateService = applicationTemplateService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateApplicationAsync([FromBody]CreateApplication applicationModel)
    {
      var response = await _applicationTemplateService.CreateApplicationAsync(applicationModel);
      return response.Status? Ok(response) : BadRequest(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetApplicationAsync(string Id)
    {
      var response = await _applicationTemplateService.GetApplicationAsync(Id);
      return response.Status? Ok(response) : BadRequest(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetApplicationsAsync()
    {
      var response = await _applicationTemplateService.GetApplicationsAsync();
      return response.Status? Ok(response) : BadRequest(response);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateApplicationAsync([FromBody] UpdateApplication updateApplicationModel, [FromQuery] string id)
    {
      var response = await _applicationTemplateService.UpdateApplicationAsync(updateApplicationModel,id);
      return response.Status? Ok(response) : BadRequest(response);
    }
    
    [HttpDelete]
    public async Task<IActionResult> DeleteApplicationAsync([FromQuery] string id)
    {
      var response = await _applicationTemplateService.DeleteApplicationAsync(id);
      return response.Status? Ok(response) : BadRequest(response);
    }
    [HttpPost]
    public async Task<IActionResult> CreateQuestionAsync([FromBody]BaseQuestionRequestModel requestModel)
    {
      var response = await _applicationTemplateService.CreateQuestionAsync(requestModel);
      return response.Status? Ok(response) : BadRequest(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetQuestionAsync(string Id)
    {
      var response = await _applicationTemplateService.GetQuestionAsync(Id);
      return response.Status? Ok(response) : BadRequest(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetQuestionsAsync()
    {
      var response = await _applicationTemplateService.GetQuestionsAsync();
      return response.Status? Ok(response) : BadRequest(response);
    }
    
    [HttpPut]
    public async Task<IActionResult> UpdateApplicationAsync([FromBody] UpdateQuestionModel updateQuestionModel, [FromQuery] string id)
    {
      var response = await _applicationTemplateService.UpdateQuestionAsync(updateQuestionModel,id);
      return response.Status? Ok(response) : BadRequest(response);
    }
    
    [HttpDelete]
    public async Task<IActionResult> DeleteQuestionAsync([FromQuery] string id)
    {
      var response = await _applicationTemplateService.DeleteQuestionAsync(id);
      return response.Status? Ok(response) : BadRequest(response);
    }
}
