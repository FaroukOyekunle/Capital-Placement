namespace ConsoleProject.Models;

public class MultipleChoiceQuestion 
{
    public List<string> Options {get; set;} = new List<string>();
    public int MaximumChoicesAllowed {get; set;}
    public bool EnableOtherOption {get; set;}
    public List<string> ChosenOptions {get; set;} = new List<string>();
}