using TaskConsole.DTOs.RequestModels;
using TaskConsole.Enums;
using TaskProjectWebAPI.Interfaces.Services;
using TaskConsole.DTOs.RetrievalModels;
using TaskConsole.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Mapster;
using TaskProjectWebAPI.Interfaces.Repositories;
using TaskConsole.DTOs.RequestModels.Stage;

namespace TaskProjectWebAPI.Implementations.Services
{
    /*
       This class defines a service named WorkflowService that implements the IWorkflowService interface.
       It offers methods for creating, updating, retrieving, and deleting stages within a workflow.
    */
    public class WorkflowService : IWorkflowService
    {
        private readonly IStageRepository _stageRepository;

        // Constructor for dependency injection
        public WorkflowService(IStageRepository stageRepository)
        {
            _stageRepository = stageRepository;
        }

        // Method to create a new stage
        public async Task<BaseResponse<bool>> CreateStageAsync(CreateStage stageRequestModel)
        {
            var baseResponse = new BaseResponse<bool>();
            try
            {
                // Check if a stage with the same name and type already exists
                var stage = await _stageRepository.GetAsync(stage => stage.StageName == stageRequestModel.StageName);

                // Handle special case for VideoInterviewStage
                if (stage is not null && stage.StageType != StageType.VideoInterview)
                    // Return an error response
                    return new BaseResponse<bool>
                    {
                        Status = false,
                        Message = $"Stage With Stage Name: {stageRequestModel.StageName} already exists",
                    };

                // Add VideoInterviewQuestions if conditions are met
                if (stage.StageType == StageType.VideoInterview && stage.VideoInterviewStage.VideoInterviewQuestions.Count < 3)
                {
                    // Add new questions and handle maximum limit
                    stage.VideoInterviewStage.VideoInterviewQuestions.AddRange(stageRequestModel.CreateVideoInterviewStage.VideoInterviewQuestions);
                    if (stage.VideoInterviewStage.VideoInterviewQuestions.Count > 3)
                    {
                        baseResponse = new BaseResponse<bool>
                        {
                            Status = false,
                            Message = "VideoInterview Stage Video Interview Questions Should Not Be greater than 3"
                        };
                    }
                    // Update the stage
                    await _stageRepository.UpdateAsync(stage);
                }

                // Create and add stages based on type
                switch (stageRequestModel.StageType.ToString())
                {
                    case "VideoInterview":
                        // Create a VideoInterviewStage
                        var stageCreated = new Stage
                        {
                            StageName = stageRequestModel.StageName,
                            StageType = stageRequestModel.StageType,
                            VideoInterviewStage = new VideoInterviewStage
                            {
                                VideoInterviewQuestions = stageRequestModel.CreateVideoInterviewStage.VideoInterviewQuestions.Select(stageQuestion => new VideoInterviewQuestion
                                {
                                    // Map VideoInterviewQuestion properties
                                }).ToList(),
                            },
                        };
                        // Add the stage to the repository
                        var saveResponse = await _stageRepository.AddAsync(stageCreated);
                        if (saveResponse is not null)
                            baseResponse = new BaseResponse<bool>
                            {
                                Status = true,
                                Message = "Stage Successfully added"
                            };
                        break;
                    default:
                        // Create a usual stage
                        var newStage = new Stage
                        {
                            StageName = stageRequestModel.StageName,
                            StageType = stageRequestModel.StageType,
                        };
                        // Add the stage to the repository
                        var savedResponse = await _stageRepository.AddAsync(newStage);
                        if (savedResponse is not null)
                            baseResponse = new BaseResponse<bool>
                            {
                                Status = true,
                                Message = "Stage Successfully added"
                            };
                        break;
                }
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("Function End...");
            }
            return baseResponse;
        }

        // Method to update a usual stage
        public async Task<BaseResponse<bool>> UpdateUsualStageAsync(UpdateUsualStage stageUpdateRequestModel, string stageName)
        {
            try
            {
                // Get the stage from the repository based on the stage name
                var stage = await _stageRepository.GetAsync(pg => pg.StageName == stageName);

                // If the stage doesn't exist, return an error response
                if (stage is null)
                {
                    return new BaseResponse<bool>
                    {
                        Status = false,
                        Message = $"Stage With Stage Name: {stageUpdateRequestModel.StageName} does not exist",
                    };
                }

                // Update the stage name and attempt to update in the repository
                stage.StageName = stageUpdateRequestModel.StageName;
                var updateResponse = await _stageRepository.UpdateAsync(stage);

                // If updating fails, return an error response
                if (updateResponse is null) return new BaseResponse<bool>
                {
                    Status = false,
                    Message = $"An error occurred! Stage could not be updated.",
                };

                // Return a success response
                return new BaseResponse<bool>
                {
                    Status = true,
                    Message = $"Stage has been updated successfully!",
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // Method to update a VideoInterview stage
        public async Task<BaseResponse<bool>> UpdateVideoInterviewStageAsync(UpdateVideoInterviewStage stageUpdateRequestModel, string stageName)
        {
            try
            {
                // Get the stage from the repository based on the stage name
                var stage = await _stageRepository.GetAsync(pg => pg.StageName == stageName);

                // If the stage doesn't exist, return an error response
                if (stage is null)
                {
                    return new BaseResponse<bool>
                    {
                        Status = false,
                        Message = $"Stage With Stage Name: {stageUpdateRequestModel.StageName} does not exist",
                    };
                }

                // Update the stage name and VideoInterviewQuestions
                stage.StageName = stageUpdateRequestModel.StageName;
                if (stage.VideoInterviewStage.VideoInterviewQuestions.Count < 3)
                {
                    stage.VideoInterviewStage.VideoInterviewQuestions.AddRange(stageUpdateRequestModel.VideoInterviewQuestions);
                    if (stage.VideoInterviewStage.VideoInterviewQuestions.Count > 3)
                    {
                        return new BaseResponse<bool>
                        {
                            Status = false,
                            Message = "VideoInterview Stage Video Interview Questions Should Not Be greater than 3"
                        };
                    }
                }
                // Update the stage in the repository
                var updateResponseStageName = (await _stageRepository.UpdateAsync(stage)).StageName;
                if (updateResponseStageName != stageUpdateRequestModel.StageName) return new BaseResponse<bool>
                {
                    Status = false,
                    Message = $"An error occurred! Stage could not be updated.",
                };
                // Return a success response
                return new BaseResponse<bool>
                {
                    Status = true,
                    Message = $"Stage has been updated successfully!",
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // Method to get all stages
        public async Task<BaseResponse<IEnumerable<StageModel>>> GetStagesAsync()
        {
            try
            {
                // Retrieve all stages from the repository
                var stages = await _stageRepository.GetAllAsync();

                // If no stages are found, return an empty data response
                if (stages.Count() == 0) return new BaseResponse<IEnumerable<StageModel>>
                {
                    Status = false,
                    Message = "Fetching Stages Returned Empty Data..."
                };

                // Map and return retrieved stages
                var stagesReturned = stages.Select(pg => pg.Adapt<StageModel>()).ToList();
                return new BaseResponse<IEnumerable<StageModel>>
                {
                    Data = stagesReturned,
                    Status = true,
                    Message = "Stages Successfully Retrieved..."
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Method to get a specific stage by its Id
        public async Task<BaseResponse<StageModel>> GetStageAsync(string Id)
        {
            try
            {
                // Retrieve the stage by its Id from the repository
                var stage = await _stageRepository.GetAsync(pg => pg.Id == Id);

                // If the stage is not found, return an empty data response
                if (stage is null) return new BaseResponse<StageModel>
                {
                    Status = false,
                    Message = "Fetching Stage Returned Empty Data..."
                };

                // Map and return the retrieved stage
                var stageReturned = stage.Adapt<StageModel>();
                return new BaseResponse<StageModel>
                {
                    Data = stageReturned,
                    Status = true,
                    Message = "Stage Successfully Retrieved..."
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // Method to delete a specific stage by its Id
        public async Task<BaseResponse<bool>> DeleteStageAsync(string Id)
        {
            try
            {
                // Retrieve the stage by its Id from the repository
                var stage = await _stageRepository.GetAsync(Id);

                // If the stage is not found, return an error response
                if (stage is null)
                {
                    return new BaseResponse<bool>
                    {
                        Status = false,
                        Message = $"Stage With Id does not exist",
                    };
                }

                // Delete the stage from the repository
                await _stageRepository.DeleteAsync(stage);

                // Return a success response
                return new BaseResponse<bool>
                {
                    Status = true,
                    Message = $"Stage has been deleted successfully!",
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
