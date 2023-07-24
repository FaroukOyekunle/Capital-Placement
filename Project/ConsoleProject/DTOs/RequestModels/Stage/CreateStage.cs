using ConsoleProject.Enums; 
using ConsoleProject.Models; 

namespace ConsoleProject.DTOs.RequestModels
{
    // CreateVideoInterviewStage class represents the data transfer object (DTO) used for creating a video interview stage
    public class CreateVideoInterviewStage
    {
        // VideoInterviewQuestions property represents a list of video interview questions for the stage
        public List<VideoInterviewQuestion> VideoInterviewQuestions { get; set; } = new List<VideoInterviewQuestion>();
    }

    // CreateStage class represents the data transfer object (DTO) used for creating a general stage
    public class CreateStage
    {
        // StageType property represents the type of the stage (e.g., video interview, assessment, etc.)
        public StageType StageType { get; set; }

        // StageName property represents the name of the stage
        public string StageName { get; set; }

        // CreateVideoInterviewStage property represents the video interview stage details, if applicable
        public CreateVideoInterviewStage CreateVideoInterviewStage { get; set; }
    }
}
