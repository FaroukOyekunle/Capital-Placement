namespace ConsoleProject.Models
{
    // DropdownQuestion represents a class that holds information about a dropdown selection question.
    public class DropdownQuestion
    {
        // Choices represents the list of options available for the dropdown question.
        public List<string> Choices { get; set; } = new List<string>();

        // EnableOtherOption indicates whether the dropdown question allows an "Other" option.
        public bool EnableOtherOption { get; set; }
    }
}
