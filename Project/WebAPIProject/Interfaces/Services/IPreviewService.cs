using TaskConsole.DTOs.RetrievalModels;
using System.Threading.Tasks;
namespace TaskProjectWebAPI.Interfaces.Services
{
    public interface IPreviewService
    {
        Task<BaseResponse<PreviewServiceModel>> GetProgramPreviewAsync(string programTitle);
    }
}