using Moq;
using Xunit;
using Shouldly;
using TestProject.Mocks;
using WebAPIProject.Interfaces.Repositories;
using WebAPIProject.Interfaces.Services;
using ConsoleProject.Enums;
using ConsoleProject.Models;
using ConsoleProject.DTOs.RequestModels;

namespace Test.ServicesTest
{
    // ProgramServiceToTest is a test class for testing the ProgramDetailsService.
    public class ProgramServiceToTest
    {
        private readonly Mock<IProgramRepository> _programRepository;
        private readonly IProgramDetailsService _programDetailsService;

        // Constructor for ProgramServiceToTest
        public ProgramServiceToTest()
        {
            // Create a mock of IProgramRepository using IProgramRepositoryMock.ProgramMock().
            _programRepository = IProgramRepositoryMock.ProgramMock();
            
            // Create an instance of ProgramDetailsService with the mocked IProgramRepository.
            _programDetailsService = new ProgramDetailsService(_programRepository.Object);
        }

        // Test method to check if adding a program with an existing object should return false for failure.
        [Fact]
        public async Task AddProgramAsync_ObjectExistsTestsSuccessfully_ReturnsFalseForFailure()
        {
            // Arrange: Create a CreateProgram object with some data.
            var createProgram = new CreateProgram
            {
                ProgramTitle = "ABCD Hackathon..",
                Description = "Hacking Challenge...",
                MaxApplications = 100,
                DurationInMonths = 10,
                ProgramStart = DateTime.UtcNow.AddMonths(3),
                ApplicantQualification = MinQualification.College,
                ApplicantSkills = new List<Skills>
                {
                    Skills.SocialMedia,
                    Skills.UIUx,
                    Skills.SEO,
                    Skills.GraphicsDesign
                },
                ApplicationCriteria = new List<string>
                {
                    "Must Be of Age 16-18",
                    "Must Be Nigerian...",
                    "Must Have Completed SSCE...",
                },
                ApplicationEnds = DateTime.Now.AddDays(3),
                ApplicationStart = DateTime.Now,
                Benefits = new List<string>
                {
                    "Accommodation",
                    "Feeding", "Allowances",
                    "Health"
                },
            };

            // Act: Attempt to add the program and get the response.
            var handler = await _programDetailsService.AddProgramAsync(createProgram);

            // Assert: The response status should be false.
            Assert.False(handler.Status);
        }

        // Test method to check if adding a program successfully should return true status in the response.
        [Fact]
        public async Task AddProgramAsync_ShouldRegisterSuccessfully_ReturnsBaseResponseWithTrueStatus()
        {
            // Arrange: Create a CreateProgram object with some data.
            var program = new CreateProgram
            {
                ApplicantQualification = MinQualification.College,
                ApplicantSkills = new List<Skills>
                {
                    Skills.SocialMedia,
                    Skills.UIUx,
                    Skills.SEO,
                    Skills.GraphicsDesign
                },
                ApplicationCriteria = new List<string>
                {
                    "Must Be of Age 16-18",
                    "Must Be Nigerian...",
                    "Must Have Completed SSCE...",
                },
                ApplicationEnds = DateTime.Now.AddDays(3),
                ApplicationStart = DateTime.Now,
                Benefits = new List<string>
                {
                    "Accommodation",
                    "Feeding", "Allowances",
                    "Health"
                },
                ProgramTitle = "EFGH Hackathon..",
                Description = "Hacking Challenge...",
                MaxApplications = 100,
                DurationInMonths = 10,
                ProgramStart = DateTime.UtcNow.AddMonths(3)
            };

            // Act: Attempt to add the program and get the response.
            var handler = await _programDetailsService.AddProgramAsync(program);
            var response = handler;

            // Assert: The response status should be true.
            response.Status.ShouldBe(true);
        }
    }
}
