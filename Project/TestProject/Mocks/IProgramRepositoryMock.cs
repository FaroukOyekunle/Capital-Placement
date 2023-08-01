using ConsoleProject.Models;
using ConsoleProject.Enums;
using Moq;
using WebAPIProject.Interfaces.Repositories;

namespace TestProject.Mocks
{
    // IProgramRepositoryMock is a class that contains mock data and setups for IProgramRepository.
    public class IProgramRepositoryMock
    {
        // ProgramMock is a static method that returns a mock of IProgramRepository.
        public static Mock<IProgramRepository> ProgramMock()
        {
            // Create two instances of Program with different data for testing purposes.
            var program1 = new Program
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
                    "Feeding",
                    "Allowances",
                    "Health"
                },
                ProgramTitle = "ABCD Hackathon..",
                Description = "Hacking Challenge...",
                MaxApplications = 100,
                DurationInMonths = 10,
                ProgramStart = DateTime.UtcNow.AddMonths(3)
            };
            var program2 = new Program
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
                    "Feeding",
                    "Allowances",
                    "Health"
                },
                ProgramTitle = "EFGH Hackathon..",
                Description = "Hacking Challenge...",
                MaxApplications = 100,
                DurationInMonths = 10,
                ProgramStart = DateTime.UtcNow.AddMonths(3)
            };
            
            // Create a mock of IProgramRepository.
            var programRepository = new Mock<IProgramRepository>();
            
            // Setup the AddAsync method to return program2 when any Program is added.
            programRepository.Setup(vR => vR.AddAsync(It.IsAny<Program>())).ReturnsAsync(program2);
            
            // Setup the AnyAsync method to return true or false based on whether the Program with program1.ProgramTitle exists.
            programRepository.Setup(vR => vR.AnyAsync(pg => pg.ProgramTitle == program1.ProgramTitle)).ReturnsAsync(true || false);
            
            // Setup the UpdateAsync method to return program1 when any Program is updated.
            programRepository.Setup(vR => vR.UpdateAsync(It.IsAny<Program>())).ReturnsAsync(program1);

            // Setup the GetAsync method to return null when trying to get a Program with program1.Id.
            // Note: The line containing this setup is commented out, as the actual method call is not used in the current code.
            // Uncomment it if you plan to use the GetAsync method in the future.
            // programRepository.Setup(vR => vR.GetAsync(It.IsAny<Program>(program1.Id))).ReturnsAsync(value: null);
            
            return programRepository;
        }
    }
}
