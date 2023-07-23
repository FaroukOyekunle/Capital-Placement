using ConsoleProject.Enums;
using ConsoleProject.Models; 

namespace ConsoleProject.DTOs.RequestModels
{
    // CreateProgram class represents the data transfer object (DTO) used for creating a new program
    public class CreateProgram
    {
        // ProgramTitle property represents the title of the new program
        public string ProgramTitle { get; set; }

        // Description property represents the description of the new program
        public string Description { get; set; }

        // ApplicantSkills property represents a list of skills required for the program,
        // initialized as an empty list by default
        public List<Skills> ApplicantSkills { get; set; } = new List<Skills>();

        // Benefits property represents a list of benefits offered by the program,
        // initialized as an empty list by default
        public List<string> Benefits { get; set; } = new List<string>();

        // ApplicationCriteria property represents a list of criteria for application,
        // initialized as an empty list by default
        public List<string> ApplicationCriteria { get; set; } = new List<string>();

        // ProgramType property represents the type of the program, using the custom ProgramType enumeration
        public ProgramType ProgramType { get; set; }

        // ProgramStart property represents the start date of the program
        public DateTime ProgramStart { get; set; }

        // ApplicationStart property represents the start date of program applications
        public DateTime ApplicationStart { get; set; }

        // ApplicationEnds property represents the end date of program applications
        public DateTime ApplicationEnds { get; set; }

        // ApplicantQualification property represents the minimum qualification required for applicants,
        // using the custom MinQualification enumeration
        public MinQualification ApplicantQualification { get; set; }

        // ProgramLocations property represents a list of locations where the program will take place,
        // initialized as an empty list by default
        public List<ProgramLocation> ProgramLocations { get; set; } = new List<ProgramLocation>();

        // DurationInMonths property represents the duration of the program in months
        public int DurationInMonths { get; set; }

        // MaxApplications property represents the maximum number of applications allowed for the program
        public int MaxApplications { get; set; }
    }
}
