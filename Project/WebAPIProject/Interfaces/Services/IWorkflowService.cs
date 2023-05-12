using TaskConsole.DTOs.RetrievalModels;
using TaskConsole.DTOs.RequestModels;
using System.Threading.Tasks;
using System.Collections.Generic;
using TaskConsole.DTOs.RequestModels.Stage;

namespace TaskProjectWebAPI.Interfaces.Services
{
    public interface IWorkflowService
    {
        Task<BaseResponse<bool>> CreateStageAsync(CreateStage stageRequestModel);
        Task<BaseResponse<bool>> UpdateUsualStageAsync(UpdateUsualStage stageUpdateRequestModel, string stageName);
        Task<BaseResponse<bool>> UpdateVideoInterviewStageAsync(UpdateVideoInterviewStage stageUpdateRequestModel, string stageName);
        Task<BaseResponse<IEnumerable<StageModel>>> GetStagesAsync();
        Task<BaseResponse<StageModel>> GetStageAsync(string Id);
        Task<BaseResponse<bool>> DeleteStageAsync(string Id);
    }
}