namespace ConsoleProject.DTOs.RequestModels;

public class MultipleChoiceQuestionModel
{
    public List<string> Options {get; set;} = new List<string>();
    public int MaximumNumberOfChoicesAllowed {get; set;}
    public bool EnableOtherOption {get; set;}
   // public List<string> ChosenOptions {get; set;} = new List<string>();
}
