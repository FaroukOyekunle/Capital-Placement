using TaskConsole.DTOs.RequestModels;
using TaskProjectWebAPI.Interfaces.Services;
using TaskConsole.DTOs.RetrievalModels;
using Mapster;
using TaskProjectWebAPI.Interfaces.Repositories;

namespace TaskProjectWebAPI.Interfaces.Services
{
    public class ProgramDetailsService : IProgramDetailsService
    {
        private readonly IProgramRepository _programRepository;

        public ProgramDetailsService(IProgramRepository programRepository)
        {
            _programRepository = programRepository;
        }

        public async Task<BaseResponse<bool>> AddProgramAsync(CreateProgram programModel)
        {
            try
            {
                var programExists = await _programRepository.AnyAsync(pg => pg.ProgramTitle == programModel.ProgramTitle);

                if (programExists) return new BaseResponse<bool>
                {
                    Status = false,
                    Message = $"Program With Program Title: {programModel.ProgramTitle} already exists",
                };
                var program = new TaskConsole.Models.Program
                {
                    ProgramTitle = programModel.ProgramTitle,
                    ProgramType = programModel.ProgramType,
                    ApplicantQualification = programModel.ApplicantQualification,
                    Description = programModel.Description,
                    ApplicantSkills = programModel.ApplicantSkills,
                    ApplicationCriteria = programModel.ApplicationCriteria,
                    Benefits = programModel.Benefits,
                    ApplicationEnds = programModel.ApplicationEnds,
                    ApplicationStart = programModel.ApplicationStart,
                    ProgramStart = programModel.ProgramStart,
                    DurationInMonths = programModel.DurationInMonths,
                    MaxApplications = programModel.MaxApplications,
                    ProgramLocations = programModel.ProgramLocations,
                };
                var savedResponse = await _programRepository.AddAsync(program);
                if (savedResponse is null) return new BaseResponse<bool>
                {
                    Status = false,
                    Message = $"An error occurred, Program could not be saved.",
                };

                return new BaseResponse<bool>
                {
                    Status = false,
                    Message = $"Program With Program Title: {programModel.ProgramTitle} already exists",
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public async Task<BaseResponse<bool>> EditProgramAsync(UpdateProgram programModel, string programTitle)
        {
            try
            {
                var program = await _programRepository.GetAsync(pg => pg.ProgramTitle == programTitle);

                if (program is null)
                {
                    return new BaseResponse<bool>
                    {
                        Status = false,
                        Message = $"Program With Program Title: {programTitle} does not exist",
                    };
                }
               program.Benefits.AddRange(programModel.Benefits);
                 program.ApplicationCriteria.AddRange(programModel.ApplicationCriteria);
                program.ProgramLocations.AddRange(programModel.ProgramLocations);

                var updateResponse = await _programRepository.UpdateAsync(program);
                if (updateResponse is null) return new BaseResponse<bool>
                {
                    Status = false,
                    Message = $"An error occurred! Program could not be updated.",
                };
                return new BaseResponse<bool>
                {
                    Status = true,
                    Message = $"Program has been updated successfully!",
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public async Task<BaseResponse<IEnumerable<ProgramModel>>> GetAllProgramsAsync()
        {
            try
            {
                var programs = await _programRepository.GetAllAsync();
                if (programs.Count() == 0) return new BaseResponse<IEnumerable<ProgramModel>>
                {
                    Status = false,
                    Message = "Fetching Programs Returned Empty Data..."
                };

                var programsReturned = programs.Select(pg => pg.Adapt<ProgramModel>()).ToList();
                return new BaseResponse<IEnumerable<ProgramModel>>
                {
                    Data = programsReturned,
                    Status = true,
                    Message = "Programs Successfully Retrieved..."
                }; 
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<BaseResponse<ProgramModel>> GetProgramAsync(string Id)
        {
            try
            {
                var program = await _programRepository.GetAsync(pg => pg.Id == Id);
                if (program is null) return new BaseResponse<ProgramModel>
                {
                    Status = false,
                    Message = "Fetching Program Returned Empty Data..."
                };

                var programReturned = program.Adapt<ProgramModel>();
                return new BaseResponse<ProgramModel>
                {
                    Data = programReturned,
                    Status = true,
                    Message = "Program Successfully Retrieved..."
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public async Task<BaseResponse<ProgramModel>> GetProgramByTitleAsync(string programTitle)
        {
            try
            {
                var program = await _programRepository.GetAsync(pg => pg.ProgramTitle == programTitle);
                if (program is null) return new BaseResponse<ProgramModel>
                {
                    Status = false,
                    Message = "Fetching Program Returned Empty Data..."
                };

                var programReturned = program.Adapt<ProgramModel>();
                return new BaseResponse<ProgramModel>
                {
                    Data = programReturned,
                    Status = true,
                    Message = "Program Successfully Retrieved..."
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }

         public async Task<BaseResponse<bool>> DeleteProgramAsync(string Id)
        {
            try
            {
                var program = await _programRepository.GetAsync(Id);

                if (program is null)
                {
                    return new BaseResponse<bool>
                    {
                        Status = false,
                        Message = $"program With Id does not exist",
                    };
                }

                 await _programRepository.DeleteAsync(program);
                return new BaseResponse<bool>
                {
                    Status = true,
                    Message = $"Program has been deleted successfully!",
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}