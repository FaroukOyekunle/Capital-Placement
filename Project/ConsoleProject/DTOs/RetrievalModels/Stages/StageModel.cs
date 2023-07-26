using ConsoleProject.Enums;
using ConsoleProject.Models; 

namespace ConsoleProject.DTOs.RetrievalModels
{
    // StageModel represents the data transfer object (DTO) for a stage retrieval model.
    public class StageModel
    {
        // StageName property holds the name of the stage.
        public string StageName { get; set; }

        // StageType property holds the type of the stage. It uses the StageType enumeration.
        public StageType StageType { get; set; }

        // VideoInterviewQuestion property holds the video interview question associated with the stage.
        public VideoInterviewQuestion VideoInterviewQuestion { get; set; }
    }
}
