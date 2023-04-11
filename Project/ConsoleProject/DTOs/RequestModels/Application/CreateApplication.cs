using System.ComponentModel.DataAnnotations;
using ConsoleProject.Enums;
using ConsoleProject.Models;

namespace ConsoleProject.DTOs.RequestModels;

public class CreateApplication
{
    [Required(ErrorMessage = "Fill The Application Image")]
    public string ApplicationCoverImage {get; set;}
    [Required(ErrorMessage ="Fill in The First Name")]
    public string FirstName{get; set;}
    [Required(ErrorMessage ="Fill in The Last Name")]
    public string LastName {get; set;}
    [Required(ErrorMessage ="Fill in The EmailAddress Value")]
    public string EmailAddress {get; set;}
    public string PhoneNumber {get; set;}
    public string Nationality {get; set;}
    public string CurrentResidence {get; set;}
    public string IdNumber {get; set;}
    public DateTime DateOfBirth {get; set;}
    public Gender Gender {get; set;}
    public Profile Profile {get; set;}
    public string ProgramTitle {get; set;}
}
