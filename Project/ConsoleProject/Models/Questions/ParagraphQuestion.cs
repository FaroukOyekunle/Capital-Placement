namespace ConsoleProject.Models
{
    // ParagraphQuestion represents a class that holds information about a paragraph type question.
    public class ParagraphQuestion
    {
        // QuestionId represents the unique identifier for the paragraph question.
        public Guid QuestionId { get; set; }

        // Question represents the actual question object associated with this paragraph question.
        // It allows referencing the specific question to which this paragraph belongs.
        // It is of type Question, assuming 'Question' is a class representing a general question.
        public Question Question { get; set; }
    }
}
