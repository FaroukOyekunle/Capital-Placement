using System.ComponentModel.DataAnnotations;
using ConsoleProject.Enums;

namespace ConsoleProject.Models
{
    // ProgramLocation class represents the location details of a program.
    public class ProgramLocation
    {
        // City represents the city where the program is located.
        public string City { get; set; }

        // Country represents the country where the program is located.
        public string Country { get; set; }
    }

    // Program class represents a program with additional information.
    public class Program : AdditionalInformation
    {
        // ProgramTitle is the title of the program and is required.
        [Required]
        public string ProgramTitle { get; set; }

        // Description is the description of the program and is required.
        [Required]
        public string Description { get; set; }

        // ApplicantSkills represents the required skills for applicants, initialized as an empty list.
        [Required]
        public List<Skills> ApplicantSkills { get; set; } = new List<Skills>();

        // Benefits represents the benefits offered by the program, initialized as an empty list.
        [Required]
        public List<string> Benefits { get; set; } = new List<string>();

        // ApplicationCriteria represents the criteria for application, initialized as an empty list.
        [Required]
        public List<string> ApplicationCriteria { get; set; } = new List<string>();

        // Applications represents the collection of applications for the program.
        public ICollection<Application> Applications = new HashSet<Application>();
    }

    // AdditionalInformation class represents additional information related to a program.
    public class AdditionalInformation : BaseModel
    {
        // ProgramType represents the type of the program and is required.
        [Required]
        public ProgramType ProgramType { get; set; }

        // ProgramStart represents the start date of the program and is required.
        [Required]
        public DateTime ProgramStart { get; set; }

        // ApplicationStart represents the start date of the application period and is required.
        [Required]
        public DateTime ApplicationStart { get; set; }

        // ApplicationEnds represents the end date of the application period and is required.
        [Required]
        public DateTime ApplicationEnds { get; set; }

        // ApplicantQualification represents the minimum qualification required for applicants and is required.
        [Required]
        public MinQualification ApplicantQualification { get; set; }

        // ProgramLocations represents the list of locations where the program is conducted, initialized as an empty list.
        [Required]
        public List<ProgramLocation> ProgramLocations { get; set; } = new List<ProgramLocation>();

        // DurationInMonths represents the duration of the program in months and is required.
        [Required]
        public int DurationInMonths { get; set; }

        // MaxApplications represents the maximum number of applications allowed for the program and is required.
        [Required]
        public int MaxApplications { get; set; }
    }
}
