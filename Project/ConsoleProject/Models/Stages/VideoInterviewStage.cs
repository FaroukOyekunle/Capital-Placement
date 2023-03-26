namespace ConsoleProject.Models;

public class VideoInterviewStage
{
    public List<VideoInterviewQuestion> VideoInterviewQuestions {get; set;}
}

public class VideoInterviewQuestion
{
    public string VideoTextQuestion {get; set;}
    public string AdditionalSubmissionInformation{get; set;}
    public string MaxDurationOfVideo {get; set;}
    public int DeadlineInNumberOfDays {get; set;}
}