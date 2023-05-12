
using TaskConsole.DTOs.RequestModels;
using TaskConsole.DTOs.RetrievalModels;

namespace TaskProjectWebAPI.Interfaces.Services
{
    public interface IApplicationTemplateService
    {
        Task<BaseResponse<bool>> CreateApplicationAsync(CreateApplication applicationModel);
        Task<BaseResponse<bool>> UpdateApplicationAsync(UpdateApplication applicationModel, string Id);
        Task<BaseResponse<IEnumerable<ApplicationModel>>> GetApplicationsAsync();
        Task<BaseResponse<ApplicationModel>> GetApplicationAsync(string Id);
        Task<BaseResponse<bool>> DeleteApplicationAsync(string Id);
        Task<BaseResponse<bool>> CreateQuestionAsync(BaseQuestionRequestModel questionRequestModel);
        Task<BaseResponse<bool>> UpdateQuestionAsync(UpdateQuestionModel questionUpdateModel, string Id);
        Task<BaseResponse<IEnumerable<QuestionResponseModel>>> GetQuestionsAsync();
        Task<BaseResponse<QuestionResponseModel>> GetQuestionAsync(string Id);
        Task<BaseResponse<bool>> DeleteQuestionAsync(string Id);
        
    }
}