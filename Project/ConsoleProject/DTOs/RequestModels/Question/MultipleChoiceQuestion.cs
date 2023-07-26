namespace ConsoleProject.DTOs.RequestModels
{
    // MultipleChoiceQuestionModel class represents the data transfer object (DTO) for Multiple Choice type questions
    public class MultipleChoiceQuestionModel
    {
        // Options property represents the list of available options for the multiple-choice question
        public List<string> Options { get; set; } = new List<string>();

        // MaximumNumberOfChoicesAllowed property represents the maximum number of choices allowed for the multiple-choice question
        public int MaximumNumberOfChoicesAllowed { get; set; }

        // EnableOtherOption property indicates whether an "Other" option is enabled for the multiple-choice question
        public bool EnableOtherOption { get; set; }

        // ChosenOptions property represents the list of options chosen by the user (Note: This line is commented out and might not be used currently)
        // public List<string> ChosenOptions { get; set; } = new List<string>();
    }
}
