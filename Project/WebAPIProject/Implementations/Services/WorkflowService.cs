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
    public class WorkflowService : IWorkflowService
    {
        private readonly IStageRepository _stageRepository;

        public WorkflowService(IStageRepository stageRepository)
        {
            _stageRepository = stageRepository;
        }

        public async Task<BaseResponse<bool>> CreateStageAsync(CreateStage stageRequestModel)
        {
            var baseResponse = new BaseResponse<bool>();
            try
            {
                var stage = await _stageRepository.GetAsync(stage => stage.StageName == stageRequestModel.StageName);

                if (stage is not null && stage.StageType != StageType.VideoInterview) return new BaseResponse<bool>
                {
                    Status = false,
                    Message = $"Stage With Stage Name: {stageRequestModel.StageName} already exists",
                };

                if (stage.StageType == StageType.VideoInterview && stage.VideoInterviewStage.VideoInterviewQuestions.Count < 3)
                {
                    stage.VideoInterviewStage.VideoInterviewQuestions.AddRange(stageRequestModel.CreateVideoInterviewStage.VideoInterviewQuestions);
                    if (stage.VideoInterviewStage.VideoInterviewQuestions.Count > 3)
                    {
                        baseResponse = new BaseResponse<bool>
                        {
                            Status = false,
                            Message = "VideoInterview Stage Video Interview Questions Should Not Be greater than 3"
                        };
                    }
                    await _stageRepository.UpdateAsync(stage);
                }

                switch (stageRequestModel.StageType.ToString())
                {
                    case "VideoInterview":
                        var stageCreated = new Stage
                        {
                            StageName = stageRequestModel.StageName,
                            StageType = stageRequestModel.StageType,
                            VideoInterviewStage = new VideoInterviewStage
                            {
                                VideoInterviewQuestions = stageRequestModel.CreateVideoInterviewStage.VideoInterviewQuestions.Select(stageQuestion => new VideoInterviewQuestion
                                {
                                    AdditionalSubmissionInformation = stageQuestion.AdditionalSubmissionInformation,
                                    DeadlineInNumberOfDays = stageQuestion.DeadlineInNumberOfDays,
                                    MaxDurationOfVideo = stageQuestion.MaxDurationOfVideo,
                                    VideoTextQuestion = stageQuestion.VideoTextQuestion
                                }).ToList(),
                            },
                        };
                        var saveResponse = await _stageRepository.AddAsync(stageCreated);
                        if(saveResponse is not null) baseResponse = new BaseResponse<bool>
                        {
                            Status = true,
                            Message = "Stage Successfully added"
                        };
                        break;
                    default:
                        var newStage = new Stage
                        {
                            StageName = stageRequestModel.StageName,
                            StageType = stageRequestModel.StageType,
                        };
                        var savedResponse = await _stageRepository.AddAsync(newStage);
                        if(savedResponse is not null) baseResponse = new BaseResponse<bool>
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
         
        public async Task<BaseResponse<bool>> UpdateUsualStageAsync(UpdateUsualStage stageUpdateRequestModel, string stageName)
        {
            try
            {
                var stage = await _stageRepository.GetAsync(pg => pg.StageName == stageName);

                if (stage is null)
                {
                    return new BaseResponse<bool>
                    {
                        Status = false,
                        Message = $"Stage With Stage Name: {stageUpdateRequestModel.StageName} does not exist",
                    };
                }
                stage.StageName = stageUpdateRequestModel.StageName;
                var updateResponse = await _stageRepository.UpdateAsync(stage);
                if (updateResponse is null) return new BaseResponse<bool>
                {
                    Status = false,
                    Message = $"An error occurred! Stage could not be updated.",
                };
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
        public async Task<BaseResponse<bool>> UpdateVideoInterviewStageAsync(UpdateVideoInterviewStage stageUpdateRequestModel, string stageName)
        {
            try
            {
                var stage = await _stageRepository.GetAsync(pg => pg.StageName == stageName);

                if (stage is null)
                {
                    return new BaseResponse<bool>
                    {
                        Status = false,
                        Message = $"Stage With Stage Name: {stageUpdateRequestModel.StageName} does not exist",
                    };
                }
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
                var updateResponseStageName = (await _stageRepository.UpdateAsync(stage)).StageName;
                if (updateResponseStageName  != stageUpdateRequestModel.StageName) return new BaseResponse<bool>
                {
                    Status = false,
                    Message = $"An error occurred! Stage could not be updated.",
                };
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
        public async Task<BaseResponse<IEnumerable<StageModel>>> GetStagesAsync()
        {
            try
            {
                var stages = await _stageRepository.GetAllAsync();
                if (stages.Count() == 0) return new BaseResponse<IEnumerable<StageModel>>
                {
                    Status = false,
                    Message = "Fetching Stages Returned Empty Data..."
                };

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
        public async Task<BaseResponse<StageModel>> GetStageAsync(string Id)
        {
            try
            {
                var stage = await _stageRepository.GetAsync(pg => pg.Id == Id);
                if (stage is null) return new BaseResponse<StageModel>
                {
                    Status = false,
                    Message = "Fetching Stage Returned Empty Data..."
                };

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
       
        public async Task<BaseResponse<bool>> DeleteStageAsync(string Id)
        {
            try
            {
                var stage = await _stageRepository.GetAsync(Id);

                if (stage is null)
                {
                    return new BaseResponse<bool>
                    {
                        Status = false,
                        Message = $"Stage With Id does not exist",
                    };
                }

               await _stageRepository.DeleteAsync(stage);
                
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