using ConsoleProject.Enums;
using ConsoleProject.Models;

namespace ConsoleProject.DTOs.RetrievalModels;

public class ProgramModel
{
    public DateTime ProgramStart { get; set; }
    public DateTime ApplicationStart { get; set; }
    public DateTime ApplicationEnds { get; set; }
    public MinQualification ApplicantQualification { get; set; }
    public List<ProgramLocation> ProgramLocations { get; set; } = new List<ProgramLocation>();
    public int DurationInMonths { get; set; }
    public int MaxApplications { get; set; }
    public string ProgramTitle { get; set; }
    public string Description { get; set; }
    public List<Skills> ApplicantSkills { get; set; } = new List<Skills>();
    public List<string> Benefits { get; set; } = new List<string>();
    public List<string> ApplicationCriteria { get; set; } = new List<string>();
    public ProgramType ProgramType { get; set; }
}
