using System.ComponentModel.DataAnnotations;
using ConsoleProject.Enums;

namespace ConsoleProject.Models
{
    // Stage represents a class that holds information about a specific stage in the application process.
    public class Stage : BaseModel
    {
        // StageName represents the name of the stage and is required.
        [Required]
        public string StageName { get; set; }

        // StageType represents the type of the stage (e.g., Applied, VideoInterview) and is required.
        [Required]
        public StageType StageType { get; set; }

        // VideoInterviewStage represents the video interview stage for this specific stage (optional).
        public VideoInterviewStage VideoInterviewStage { get; set; }

        // Applications represents a collection of applications associated with this stage.
        // The applications are initialized as an empty HashSet<Application>.
        public ICollection<Application> Applications { get; set; } = new HashSet<Application>();
    }
}
