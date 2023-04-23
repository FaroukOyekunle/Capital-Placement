using ConsoleProject.Enums;
using ConsoleProject.Models;

namespace ConsoleProject.DTOs.RetrievalModels;

public class ApplicationModel
{
    public string FirstName{get; set;}
    public string LastName {get; set;}
    public string EmailAddress {get; set;}
    public string PhoneNumber {get; set;}
    public string ApplicationCoverImage {get; set;}
    public string Nationality {get; set;}
    public string CurrentResidence {get; set;}
    public string IdNumber {get; set;}
    public Gender Gender {get; set;}
    public Profile Profile {get; set;}
}
