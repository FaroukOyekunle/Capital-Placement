using System.ComponentModel.DataAnnotations;
using ConsoleProject.Enums;

namespace ConsoleProject.Models;

public class Stage : BaseModel
{
    [Required]
    public string StageName { get; set; }
    [Required]
    public StageType StageType { get; set; }
    public VideoInterviewStage VideoInterviewStage { get; set; }
    public ICollection<Application> Applications { get; set; } = new HashSet<Application>();
}
