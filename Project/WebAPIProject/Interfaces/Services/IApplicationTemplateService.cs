using TaskConsole.DTOs.RequestModels;
using TaskConsole.DTOs.RetrievalModels;

namespace TaskProjectWebAPI.Interfaces.Services
{
    // The interface IApplicationTemplateService defines methods related to application and question manipulation
    public interface IApplicationTemplateService
    {
        // Creates a new application asynchronously
        Task<BaseResponse<bool>> CreateApplicationAsync(CreateApplication applicationModel);

        // Updates an existing application asynchronously by Id
        Task<BaseResponse<bool>> UpdateApplicationAsync(UpdateApplication applicationModel, string Id);

        // Retrieves all applications asynchronously
        Task<BaseResponse<IEnumerable<ApplicationModel>>> GetApplicationsAsync();

        // Retrieves an application by Id asynchronously
        Task<BaseResponse<ApplicationModel>> GetApplicationAsync(string Id);

        // Deletes an application by Id asynchronously
        Task<BaseResponse<bool>> DeleteApplicationAsync(string Id);

        // Creates a new question asynchronously
        Task<BaseResponse<bool>> CreateQuestionAsync(BaseQuestionRequestModel questionRequestModel);

        // Updates an existing question asynchronously by Id
        Task<BaseResponse<bool>> UpdateQuestionAsync(UpdateQuestionModel questionUpdateModel, string Id);

        // Retrieves all questions asynchronously
        Task<BaseResponse<IEnumerable<QuestionResponseModel>>> GetQuestionsAsync();

        // Retrieves a question by Id asynchronously
        Task<BaseResponse<QuestionResponseModel>> GetQuestionAsync(string Id);

        // Deletes a question by Id asynchronously
        Task<BaseResponse<bool>> DeleteQuestionAsync(string Id);
    }
}
