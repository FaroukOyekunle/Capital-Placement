using TaskConsole.DTOs.RetrievalModels;
using TaskConsole.DTOs.RequestModels;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TaskProjectWebAPI.Interfaces.Services
{
    public interface IProgramDetailsService
    {
        Task<BaseResponse<bool>> AddProgramAsync(CreateProgram programModel);
        Task<BaseResponse<bool>> EditProgramAsync(UpdateProgram programModel, string programTitle);
        Task<BaseResponse<IEnumerable<ProgramModel>>> GetAllProgramsAsync();
        Task<BaseResponse<ProgramModel>> GetProgramAsync(string Id);
        Task<BaseResponse<ProgramModel>> GetProgramByTitleAsync(string programTitle);
        Task<BaseResponse<bool>> DeleteProgramAsync(string Id);
    }
}
