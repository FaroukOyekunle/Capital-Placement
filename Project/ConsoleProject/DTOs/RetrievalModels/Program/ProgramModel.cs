using ConsoleProject.Enums; 
using ConsoleProject.Models;
using System; 

namespace ConsoleProject.DTOs.RetrievalModels
{
    // ProgramModel represents the data transfer object (DTO) for a program retrieval model.
    public class ProgramModel
    {
        // ProgramStart property holds the start date of the program.
        public DateTime ProgramStart { get; set; }

        // ApplicationStart property holds the start date of the application process.
        public DateTime ApplicationStart { get; set; }

        // ApplicationEnds property holds the end date of the application process.
        public DateTime ApplicationEnds { get; set; }

        // ApplicantQualification property holds the minimum qualification required for applicants. It uses the MinQualification enumeration.
        public MinQualification ApplicantQualification { get; set; }

        // ProgramLocations property holds the list of program locations. It uses the ProgramLocation class from the Models namespace.
        public List<ProgramLocation> ProgramLocations { get; set; } = new List<ProgramLocation>();

        // DurationInMonths property holds the duration of the program in months.
        public int DurationInMonths { get; set; }

        // MaxApplications property holds the maximum number of applications allowed for the program.
        public int MaxApplications { get; set; }

        // ProgramTitle property holds the title of the program.
        public string ProgramTitle { get; set; }

        // Description property holds the description of the program.
        public string Description { get; set; }

        // ApplicantSkills property holds the list of applicant skills. It uses the Skills enumeration.
        public List<Skills> ApplicantSkills { get; set; } = new List<Skills>();

        // Benefits property holds the list of program benefits.
        public List<string> Benefits { get; set; } = new List<string>();

        // ApplicationCriteria property holds the list of application criteria.
        public List<string> ApplicationCriteria { get; set; } = new List<string>();

        // ProgramType property represents the type of the program. It uses the ProgramType enumeration.
        public ProgramType ProgramType { get; set; }
    }
}
