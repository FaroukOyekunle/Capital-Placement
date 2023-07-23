using ConsoleProject.Models; 

namespace ConsoleProject.DTOs.RequestModels.Stage
{
    // UpdateVideoInterviewStage class represents the data transfer object (DTO) used for updating a video interview stage
    public class UpdateVideoInterviewStage
    {
        // StageName property represents the updated name of the video interview stage
        public string StageName { get; set; }

        // VideoInterviewQuestions property represents a list of updated video interview questions for the stage
        public List<VideoInterviewQuestion> VideoInterviewQuestions { get; set; } = new List<VideoInterviewQuestion>();
    }

    // UpdateUsualStage class represents the data transfer object (DTO) used for updating a usual (generic) stage
    public class UpdateUsualStage
    {
        // StageName property represents the updated name of the usual stage
        public string StageName { get; set; }
    }
}
