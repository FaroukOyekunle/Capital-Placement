using ConsoleProject.Models;

namespace ConsoleProject.DTOs.RetrievalModels;

public class QuestionResponseModel
{
    public YesOrNoQuestion YesOrNoQuestion { get; set; }
    public ShortAnswerQuestion ShortAnswerQuestion { get; set; }
    public ParagraphQuestion ParagraphQuestion { get; set; }
    public string QuestionContent { get; set; }
    public MultipleChoiceQuestion MultipleChoiceQuestion { get; set; }
    public DropdownQuestion DropdownQuestion { get; set; }
    public DateQuestion DateQuestion { get; set; }
    public FileUploadQuestion FileUploadQuestion { get; set; }
    public NumberQuestion NumberQuestion { get; set; }
    public VideoBasedQuestion VideoBasedQuestion { get; set; }
    public string Response { get; set; }
}
