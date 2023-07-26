namespace ConsoleProject.DTOs.RequestModels
{
    // VideoQuestionModel class represents the data transfer object (DTO) for video-related questions
    public class VideoQuestionModel
    {
        // AdditionalSubmissionInformation property represents any additional information the user may want to provide while submitting the video
        public string AdditionalSubmissionInformation { get; set; }

        // MaxDurationOfVideo property represents the maximum duration allowed for the video
        public string MaxDurationOfVideo { get; set; }
    }
}
