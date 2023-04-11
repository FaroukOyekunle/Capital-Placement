using ConsoleProject.Enums;

namespace ConsoleProject.DTOs.RequestModels;

public  class BaseQuestionRequestModel
{
    public QuestionType QuestionType {get; set;}

    public string QuestionContent {get; set;}

    public DropdownQuestionModel DropdownQuestionModel {get; set;}

    public FileUploadQuestionModel FileUploadQuestionModel {get; set;}

    public MultipleChoiceQuestionModel MultipleChoiceQuestionModel {get; set;}

    public VideoQuestionModel VideoQuestionModel {get; set;}

    public YesOrNoQuestionModel YesOrNoQuestionModel {get; set;}

    public NumberQuestionModel NumberQuestionModel {get; set;}
    
    public DateQuestionModel DateQuestionModel {get; set;}
}
