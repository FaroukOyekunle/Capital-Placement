namespace ConsoleProject.Models
{
    // VideoInterviewStage represents a class that holds a list of video interview questions for a stage.
    public class VideoInterviewStage
    {
        // VideoInterviewQuestions represents a list of video interview questions for the stage.
        public List<VideoInterviewQuestion> VideoInterviewQuestions { get; set; }
    }

    // VideoInterviewQuestion represents a class that holds information about a video interview question.
    public class VideoInterviewQuestion
    {
        // VideoTextQuestion stores the text of the video interview question.
        public string VideoTextQuestion { get; set; }

        // AdditionalSubmissionInformation provides additional information for the video interview question submission.
        public string AdditionalSubmissionInformation { get; set; }

        // MaxDurationOfVideo represents the maximum allowed duration of the video response.
        public string MaxDurationOfVideo { get; set; }

        // DeadlineInNumberOfDays indicates the number of days allowed to respond to the question.
        public int DeadlineInNumberOfDays { get; set; }
    }
}
