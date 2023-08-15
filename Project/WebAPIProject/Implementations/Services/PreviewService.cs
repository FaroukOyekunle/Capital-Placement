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
        // Private fields to hold references to repositories
        private readonly IProgramRepository _programRepository;
        private readonly IApplicationRepository _appRepository;

        // Constructor with dependency injection
        public PreviewService(IProgramRepository programRepository, IApplicationRepository appRepository)
        {
            _programRepository = programRepository;
            _appRepository = appRepository;
        }

        // Method to get program preview asynchronously
        public async Task<BaseResponse<PreviewServiceModel>> GetProgramPreviewAsync(string programTitle)
        {
            try
            {
                // Retrieve program from the repository based on the program title
                var program = await _programRepository.GetAsync(pg => pg.ProgramTitle == programTitle);
                
                // Retrieve application related to the program
                var application = await _appRepository.GetAsync(application => application.ProgramId == program.Id);
                
                // Check if the program is found, if not, return an error response
                if (program is null) return new BaseResponse<PreviewServiceModel>
                {
                    Status = false,
                    Message = $"Program With The Title: {programTitle} could not be found",
                };

                // Create a preview model containing program and application details
                var previewModel = new PreviewServiceModel
                {
                    ProgramModel = program.Adapt<ProgramModel>(),
                    ApplicationCoverImage = application.ApplicationCoverImage,
                };

                // Return a success response with the preview model
                return new BaseResponse<PreviewServiceModel>
                {
                    Data = previewModel,
                    Message = "Successful Retrieval Of Program",
                    Status = true,
                };
            }
            catch (Exception)
            {
                throw; // Re-throw the exception
            }
        }
    }
}
