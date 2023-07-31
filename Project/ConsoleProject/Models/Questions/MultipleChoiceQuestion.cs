namespace ConsoleProject.Models
{
    // MultipleChoiceQuestion represents a class that holds information about a multiple-choice question.
    public class MultipleChoiceQuestion
    {
        // Options represents a list of strings containing the available choices for the question.
        public List<string> Options { get; set; } = new List<string>();

        // MaximumChoicesAllowed represents the maximum number of choices a user can select for the question.
        public int MaximumChoicesAllowed { get; set; }

        // EnableOtherOption is a boolean flag indicating whether an "Other" option is enabled for the question.
        public bool EnableOtherOption { get; set; }

        // ChosenOptions represents a list of strings containing the choices selected by the user.
        // It is initialized with an empty list by default and will be populated with the selected options.
        public List<string> ChosenOptions { get; set; } = new List<string>();
    }
}
