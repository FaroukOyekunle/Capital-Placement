namespace ConsoleProject.Models
{
    // VideoBasedQuestion represents a class that holds information about a video-based question.
    public class VideoBasedQuestion
    {
        // AdditionalSubmissionInformation stores additional information or instructions
        // for the applicant regarding the video submission.
        public string AdditionalSubmissionInformation { get; set; }

        // MaxDurationOfVideo specifies the maximum duration allowed for the video response.
        // It stores the duration of the video in a string format, e.g., "5 minutes".
        public string MaxDurationOfVideo { get; set; }
    }
}
