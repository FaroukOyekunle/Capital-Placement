namespace ConsoleProject.Models
{
    // Question represents a class that holds information about different types of questions.
    public class Question : BaseModel
    {
        // DateQuestion represents a property that holds a DateQuestion object.
        // It allows attaching a date-based question to this general question object.
        public DateQuestion DateQuestion { get; set; }

        // YesOrNoQuestion represents a property that holds a YesOrNoQuestion object.
        // It allows attaching a yes/no type question to this general question object.
        public YesOrNoQuestion YesOrNoQuestion { get; set; }

        // ShortAnswerQuestion represents a property that holds a ShortAnswerQuestion object.
        // It allows attaching a short answer type question to this general question object.
        public ShortAnswerQuestion ShortAnswerQuestion { get; set; }

        // QuestionContent represents the content or prompt of the question.
        public string QuestionContent { get; set; }

        // NumberQuestion represents a property that holds a NumberQuestion object.
        // It allows attaching a numeric type question to this general question object.
        public NumberQuestion NumberQuestion { get; set; }

        // MultipleChoiceQuestion represents a property that holds a MultipleChoiceQuestion object.
        // It allows attaching a multiple-choice type question to this general question object.
        public MultipleChoiceQuestion MultipleChoiceQuestion { get; set; }

        // ParagraphQuestion represents a property that holds a ParagraphQuestion object.
        // It allows attaching a paragraph type question to this general question object.
        public ParagraphQuestion ParagraphQuestion { get; set; }

        // FileUploadQuestion represents a property that holds a FileUploadQuestion object.
        // It allows attaching a file upload type question to this general question object.
        public FileUploadQuestion FileUploadQuestion { get; set; }

        // DropdownQuestion represents a property that holds a DropdownQuestion object.
        // It allows attaching a dropdown type question to this general question object.
        public DropdownQuestion DropdownQuestion { get; set; }

        // VideoBasedQuestion represents a property that holds a VideoBasedQuestion object.
        // It allows attaching a video-based type question to this general question object.
        public VideoBasedQuestion VideoBasedQuestion { get; set; }

        // Response represents a property that holds the response given by the applicant for this question.
        public string Response { get; set; }
    }
}
