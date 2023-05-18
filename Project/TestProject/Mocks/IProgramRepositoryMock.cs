using ConsoleProject.Models;
using ConsoleProject.Enums;
using Moq;
using WebAPIProject.Interfaces.Repositories;

namespace TestProject.Mocks;

public class IProgramRepositoryMock
{
     public static Mock<IProgramRepository> ProgramMock()
    {
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
                "Feeding", "Allowances",
                "Health"
            },
            ProgramTitle = "ABCD Hackhathon..",
            Description ="Hacking Challenge...",
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
                "Feeding", "Allowances",
                "Health"
            },
            ProgramTitle = "EFGH Hackhathon..",
            Description ="Hacking Challenge...",
            MaxApplications = 100,
            DurationInMonths = 10,
            ProgramStart = DateTime.UtcNow.AddMonths(3)
       };
       var programRepository = new Mock<IProgramRepository>();
       programRepository.Setup(vR => vR.AddAsync(It.IsAny<Program>())).ReturnsAsync(program2);
       programRepository.Setup(vR => vR.AnyAsync(pg => pg.ProgramTitle == program1.ProgramTitle)).ReturnsAsync(true || false);
       programRepository.Setup(vR => vR.UpdateAsync(It.IsAny<Program>())).ReturnsAsync(program1);
      // programRepository.Setup(vR => vR.GetAsync(It.IsAny<Program>(program1.Id))).ReturnsAsync(value : null);
       return programRepository;
    }
}
