namespace ConsoleProject.DTOs.RequestModels
{
    // DropdownQuestionModel class represents the data transfer object (DTO) for Dropdown type questions
    public class DropdownQuestionModel
    {
        // Choices property represents a list of string options for the Dropdown question
        public List<string> Choices { get; set; } = new List<string>();

        // EnableOtherOption property indicates whether the "Other" option is enabled for the Dropdown question
        public bool EnableOtherOption { get; set; }
    }
}
