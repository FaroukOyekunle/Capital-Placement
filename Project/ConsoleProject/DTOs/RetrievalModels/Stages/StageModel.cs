using ConsoleProject.Enums;
using ConsoleProject.Models;

namespace ConsoleProject.DTOs.RetrievalModels;

public class StageModel
{
    public string StageName { get; set; }
    public StageType StageType { get; set; }
    public VideoInterviewQuestion VideoInterviewQuestion { get; set; }
}
