using TaskConsole.DTOs.RequestModels;
using TaskProjectWebAPI.Interfaces.Services;
using TaskConsole.DTOs.RetrievalModels;
using Mapster;
using TaskProjectWebAPI.Interfaces.Repositories;

namespace TaskProjectWebAPI.Interfaces.Services
{
    // Service for managing program details
    public class ProgramDetailsService : IProgramDetailsService
    {
        private readonly IProgramRepository _programRepository;

        // Constructor for dependency injection
        public ProgramDetailsService(IProgramRepository programRepository)
        {
            _programRepository = programRepository;
        }

        // Method to add a new program
        public async Task<BaseResponse<bool>> AddProgramAsync(CreateProgram programModel)
        {
            try
            {
                // Check if a program with the same title already exists
                var programExists = await _programRepository.AnyAsync(pg => pg.ProgramTitle == programModel.ProgramTitle);

                // If program exists, return an error response
                if (programExists) return new BaseResponse<bool>
                {
                    Status = false,
                    Message = $"Program With Program Title: {programModel.ProgramTitle} already exists",
                };

                // Create a new program instance
                var program = new TaskConsole.Models.Program
                {
                    ProgramTitle = programModel.ProgramTitle,
                    ProgramType = programModel.ProgramType,
                    // Initialize other properties from the model
                };

                // Add the program to the repository
                var savedResponse = await _programRepository.AddAsync(program);

                // If saving fails, return an error response
                if (savedResponse is null) return new BaseResponse<bool>
                {
                    Status = false,
                    Message = $"An error occurred, Program could not be saved.",
                };

                // Return a success response
                return new BaseResponse<bool>
                {
                    Status = false,
                    Message = $"Program added successfully",
                };
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // Method to edit an existing program
        public async Task<BaseResponse<bool>> EditProgramAsync(UpdateProgram programModel, string programTitle)
        {
            try
            {
                // Get the program from the repository based on the program title
                var program = await _programRepository.GetAsync(pg => pg.ProgramTitle == programTitle);

                // If the program doesn't exist, return an error response
                if (program is null)
                {
                    return new BaseResponse<bool>
                    {
                        Status = false,
                        Message = $"Program With Program Title: {programTitle} does not exist",
                    };
                }

                // Update the program properties
                program.Benefits.AddRange(programModel.Benefits);
                program.ApplicationCriteria.AddRange(programModel.ApplicationCriteria);
                program.ProgramLocations.AddRange(programModel.ProgramLocations);

                // Attempt to update the program in the repository
                var updateResponse = await _programRepository.UpdateAsync(program);

                // If updating fails, return an error response
                if (updateResponse is null) return new BaseResponse<bool>
                {
                    Status = false,
                    Message = $"An error occurred! Program could not be updated.",
                };

                // Return a success response
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

        // Method to get all programs
        public async Task<BaseResponse<IEnumerable<ProgramModel>>> GetAllProgramsAsync()
        {
            try
            {
                // Retrieve all programs from the repository
                var programs = await _programRepository.GetAllAsync();

                // If no programs are found, return an empty data response
                if (programs.Count() == 0) return new BaseResponse<IEnumerable<ProgramModel>>
                {
                    Status = false,
                    Message = "Fetching Programs Returned Empty Data..."
                };

                // Adapt and map each program to the DTO model
                var programsReturned = programs.Select(pg => pg.Adapt<ProgramModel>()).ToList();

                // Return a success response with the mapped programs
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

        // Method to get a program by ID
        public async Task<BaseResponse<ProgramModel>> GetProgramAsync(string Id)
        {
            try
            {
                // Retrieve a program from the repository based on the provided ID
                var program = await _programRepository.GetAsync(pg => pg.Id == Id);

                // If the program doesn't exist, return an error response
                if (program is null) return new BaseResponse<ProgramModel>
                {
                    Status = false,
                    Message = "Fetching Program Returned Empty Data..."
                };

                // Adapt and map the program to the DTO model
                var programReturned = program.Adapt<ProgramModel>();

                // Return a success response with the mapped program
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

        // Method to get a program by title
        public async Task<BaseResponse<ProgramModel>> GetProgramByTitleAsync(string programTitle)
        {
            try
            {
                // Retrieve a program from the repository based on the provided title
                var program = await _programRepository.GetAsync(pg => pg.ProgramTitle == programTitle);

                // If the program doesn't exist, return an error response
                if (program is null) return new BaseResponse<ProgramModel>
                {
                    Status = false,
                    Message = "Fetching Program Returned Empty Data..."
                };

                // Adapt and map the program to the DTO model
                var programReturned = program.Adapt<ProgramModel>();

                // Return a success response with the mapped program
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

        // Method to delete a program by ID
        public async Task<BaseResponse<bool>> DeleteProgramAsync(string Id)
        {
            try
            {
                // Retrieve a program from the repository based on the provided ID
                var program = await _programRepository.GetAsync(Id);

                // If the program doesn't exist, return an error response
                if (program is null)
                {
                    return new BaseResponse<bool>
                    {
                        Status = false,
                        Message = $"program With Id does not exist",
                    };
                }

                // Delete the program from the repository
                await _programRepository.DeleteAsync(program);

                // Return a success response
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
