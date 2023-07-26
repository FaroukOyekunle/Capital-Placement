using ConsoleProject.Models;

namespace ConsoleProject.DTOs.RetrievalModels
{
    // QuestionResponseModel represents the data transfer object (DTO) for storing responses to different types of questions
    public class QuestionResponseModel
    {
        // YesOrNoQuestion property represents the user's response to a yes or no question
        public YesOrNoQuestion YesOrNoQuestion { get; set; }

        // ShortAnswerQuestion property represents the user's response to a short answer question
        public ShortAnswerQuestion ShortAnswerQuestion { get; set; }

        // ParagraphQuestion property represents the user's response to a paragraph-based question
        public ParagraphQuestion ParagraphQuestion { get; set; }

        // QuestionContent property represents the content or text of the question
        public string QuestionContent { get; set; }

        // MultipleChoiceQuestion property represents the user's response to a multiple-choice question
        public MultipleChoiceQuestion MultipleChoiceQuestion { get; set; }

        // DropdownQuestion property represents the user's response to a dropdown (select) question
        public DropdownQuestion DropdownQuestion { get; set; }

        // DateQuestion property represents the user's response to a date-based question
        public DateQuestion DateQuestion { get; set; }

        // FileUploadQuestion property represents the user's response to a file upload-based question
        public FileUploadQuestion FileUploadQuestion { get; set; }

        // NumberQuestion property represents the user's response to a number-based question
        public NumberQuestion NumberQuestion { get; set; }

        // VideoBasedQuestion property represents the user's response to a video-based question
        public VideoBasedQuestion VideoBasedQuestion { get; set; }

        // Response property represents the user's response in a generic string format
        public string Response { get; set; }
    }
}
