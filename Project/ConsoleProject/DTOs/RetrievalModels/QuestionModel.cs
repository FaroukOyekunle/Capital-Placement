using ConsoleProject.Models;

namespace ConsoleProject.DTOs.RetrievalModels;

public class QuestionModel
{
    public DateQuestion DateQuestion{get; set;}
    public YesOrNoQuestion YesOrNoQuestion{get; set;}
    public string QuestionContent {get; set;}
    public FileUploadQuestion FileUploadQuestion{get; set;}
    public NumberQuestion NumberQuestion{get; set;}
    public MultipleChoiceQuestion MultipleChoiceQuestion{get; set;}
    public ShortAnswerQuestion ShortAnswerQuestion{get; set;}
    public ParagraphQuestion ParagraphQuestion{get; set;}
    public DropdownQuestion DropdownQuestion{get; set;}
    public VideoBasedQuestion VideoBasedQuestion{get; set;}
    public string Response {get; set;}
}
