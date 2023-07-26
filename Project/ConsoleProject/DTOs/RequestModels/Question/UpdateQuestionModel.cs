namespace ConsoleProject.DTOs.RequestModels
{
    // UpdateQuestionModel class represents the data transfer object (DTO) for updating a question
    public class UpdateQuestionModel
    {
        // Response property represents the user's response to the question
        public string Response { get; set; }

        // QuestionContent property represents the content of the question being updated
        public string QuestionContent { get; set; }
    }
}
