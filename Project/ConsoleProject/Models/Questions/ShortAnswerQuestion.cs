namespace ConsoleProject.Models
{
    // ShortAnswerQuestion represents a class that holds information about a short answer type question.
    public class ShortAnswerQuestion
    {
        // Question represents the actual question object associated with this short answer question.
        // It allows referencing the specific question to which this short answer belongs.
        public Question Question { get; set; }
    }
}
