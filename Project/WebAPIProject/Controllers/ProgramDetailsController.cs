using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ConsoleProject.DTOs.RequestModels;
using ConsoleProject.DTOs.RetrievalModels;
using WebAPIProject.Interfaces.Services;

namespace WebAPIProject.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProgramDetailsController : ControllerBase
{
    public IProgramDetailsService _programDetailsService;

    public ProgramDetailsController(IProgramDetailsService programDetailsService)
    {
        _programDetailsService = programDetailsService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateProgramAsync([FromBody] CreateProgram programRequestModel)
    {
        var response = await _programDetailsService.AddProgramAsync(programRequestModel);
        return response.Status ? Ok(response) : BadRequest(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetProgramAsync([FromQuery] string Id)
    {
        var response = await _programDetailsService.GetProgramAsync(Id);
        return response.Status ? Ok(response) : BadRequest(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProgramsAsync()
    {
        var response = await _programDetailsService.GetAllProgramsAsync();
        return response.Status ? Ok(response) : BadRequest(response);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProgramAsync([FromBody] UpdateProgram updateProgram, [FromQuery] string programTitle)
    {
        var response = await _programDetailsService.EditProgramAsync(updateProgram, programTitle);
        return response.Status ? Ok(response) : BadRequest(response);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteStageAsync([FromQuery] string id)
    {
        var response = await _programDetailsService.DeleteProgramAsync(id);
        return response.Status ? Ok(response) : BadRequest(response);
    }
}
