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
    public class ProgramServiceToTest
    {
        private readonly Mock<IProgramRepository> _programRepository;

        private readonly IProgramDetailsService _programDetailsService;

        public ProgramServiceToTest()
        {
            _programRepository = IProgramRepositoryMock.ProgramMock();
            _programDetailsService = new ProgramDetailsService(_programRepository.Object);
        }

        [Fact]
        public async Task AddProgramAsync_ObjectExistsTestsSuccessfully_ReturnsFalseForFailure()
        {
            var createProgram = new CreateProgram
            {
                ProgramTitle = "ABCD Hackhathon..",
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
            //Act
            var handler = await _programDetailsService.AddProgramAsync(createProgram);
            //Assert                                                 
            Assert.False(handler.Status);
        }


        [Fact]
        public async Task AddProgramAsync_ShouldRegisterSuccessfully_ReturnsBaseResponseWithTrueStatus()
        {
            //Arrange
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
                ProgramTitle = "EFGH Hackhathon..",
                Description = "Hacking Challenge...",
                MaxApplications = 100,
                DurationInMonths = 10,
                ProgramStart = DateTime.UtcNow.AddMonths(3)
            };
            //Act
            var handler = await _programDetailsService.AddProgramAsync(program);
            var response = handler;

            //Assert
            response.Status.ShouldBe(true);
        }
    }
}