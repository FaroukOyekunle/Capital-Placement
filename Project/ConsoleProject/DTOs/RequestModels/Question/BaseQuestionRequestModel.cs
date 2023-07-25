using ConsoleProject.Enums; 

namespace ConsoleProject.DTOs.RequestModels
{
    // BaseQuestionRequestModel class represents the data transfer object (DTO) used for sending a request to create a new question
    public class BaseQuestionRequestModel
    {
        // QuestionType property represents the type of the question (e.g., Dropdown, FileUpload, MultipleChoice, etc.)
        public QuestionType QuestionType { get; set; }

        // QuestionContent property represents the content of the question (the actual question text)
        public string QuestionContent { get; set; }

        // DropdownQuestionModel property represents a specific model for Dropdown type questions, if applicable
        public DropdownQuestionModel DropdownQuestionModel { get; set; }

        // FileUploadQuestionModel property represents a specific model for FileUpload type questions, if applicable
        public FileUploadQuestionModel FileUploadQuestionModel { get; set; }

        // MultipleChoiceQuestionModel property represents a specific model for MultipleChoice type questions, if applicable
        public MultipleChoiceQuestionModel MultipleChoiceQuestionModel { get; set; }

        // VideoQuestionModel property represents a specific model for Video type questions, if applicable
        public VideoQuestionModel VideoQuestionModel { get; set; }

        // YesOrNoQuestionModel property represents a specific model for YesOrNo type questions, if applicable
        public YesOrNoQuestionModel YesOrNoQuestionModel { get; set; }

        // NumberQuestionModel property represents a specific model for Number type questions, if applicable
        public NumberQuestionModel NumberQuestionModel { get; set; }

        // DateQuestionModel property represents a specific model for Date type questions, if applicable
        public DateQuestionModel DateQuestionModel { get; set; }
    }
}
