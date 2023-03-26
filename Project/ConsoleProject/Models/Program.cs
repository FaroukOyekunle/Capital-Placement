using System.ComponentModel.DataAnnotations;
using ConsoleProject.Enums;

namespace ConsoleProject.Models;

public class ProgramLocation
{
    public string City { get; set; }
    public string Country { get; set; }
}

public class Program : AdditionalInformation
{
    [Required]
    public string ProgramTitle { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public List<Skills> ApplicantSkills { get; set; } = new List<Skills>();
    [Required]
    public List<string> Benefits { get; set; } = new List<string>();
    [Required]
    public List<string> ApplicationCriteria { get; set; } = new List<string>();
    public ICollection<Application> Applications = new HashSet<Application>();

}

public class AdditionalInformation : BaseModel
{
    [Required]
    public ProgramType ProgramType { get; set; }
    [Required]
    public DateTime ProgramStart { get; set; }
    [Required]
    public DateTime ApplicationStart { get; set; }
    [Required]
    public DateTime ApplicationEnds { get; set; }
    [Required]
    public MinQualification ApplicantQualification { get; set; }
    [Required]
    public List<ProgramLocation> ProgramLocations { get; set; } = new List<ProgramLocation>();
    [Required]
    public int DurationInMonths { get; set; }
    [Required]
    public int MaxApplications { get; set; }
}