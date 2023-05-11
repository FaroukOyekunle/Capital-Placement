using TaskProjectWebAPI.Interfaces.Services;
using TaskProjectWebAPI.Interfaces.Repositories;
using TaskConsole.DTOs.RetrievalModels;
using TaskConsole.DTOs.RequestModels;
using TaskConsole.Models;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
namespace TaskProjectWebAPI.Implementations.Services
{
    public class PreviewService : IPreviewService
    {
        public IProgramRepository _programRepository;
        public IApplicationRepository _appRepository;

        public PreviewService(IProgramRepository programRepository, IApplicationRepository appRepository)
        {
            _programRepository = programRepository;
            _appRepository = appRepository;
        }
        public async Task<BaseResponse<PreviewServiceModel>> GetProgramPreviewAsync(string programTitle)
        {
            try
            {
                var program = await _programRepository.GetAsync(pg => pg.ProgramTitle == programTitle);
                var application = await _appRepository.GetAsync(application => application.ProgramId == program.Id);
                if (program is null) return new BaseResponse<PreviewServiceModel>
                {
                    Status = false,
                    Message = $"Program With The Title: {programTitle} could not be found",
                };
                var previewModel = new PreviewServiceModel
                {
                    ProgramModel = program.Adapt<ProgramModel>(),
                    ApplicationCoverImage = application.ApplicationCoverImage,
                };
                return new BaseResponse<PreviewServiceModel>
                {
                    Data = previewModel,
                    Message = "Successful Retrieval Of Program",
                    Status = true,
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}