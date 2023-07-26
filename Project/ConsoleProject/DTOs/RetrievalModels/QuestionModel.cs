using ConsoleProject.Models;

namespace ConsoleProject.DTOs.RetrievalModels
{
    // QuestionModel represents the data transfer object (DTO) for storing various types of questions and their responses
    public class QuestionModel
    {
        // DateQuestion property represents a date-based question
        public DateQuestion DateQuestion { get; set; }

        // YesOrNoQuestion property represents a yes or no question
        public YesOrNoQuestion YesOrNoQuestion { get; set; }

        // QuestionContent property represents the content or text of the question
        public string QuestionContent { get; set; }

        // FileUploadQuestion property represents a file upload-based question
        public FileUploadQuestion FileUploadQuestion { get; set; }

        // NumberQuestion property represents a number-based question
        public NumberQuestion NumberQuestion { get; set; }

        // MultipleChoiceQuestion property represents a multiple-choice question
        public MultipleChoiceQuestion MultipleChoiceQuestion { get; set; }

        // ShortAnswerQuestion property represents a short answer question
        public ShortAnswerQuestion ShortAnswerQuestion { get; set; }

        // ParagraphQuestion property represents a paragraph-based question
        public ParagraphQuestion ParagraphQuestion { get; set; }

        // DropdownQuestion property represents a dropdown (select) question
        public DropdownQuestion DropdownQuestion { get; set; }

        // VideoBasedQuestion property represents a video-based question
        public VideoBasedQuestion VideoBasedQuestion { get; set; }

        // Response property represents the user's response in a generic string format
        public string Response { get; set; }
    }
}
