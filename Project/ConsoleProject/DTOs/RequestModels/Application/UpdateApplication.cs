using System.ComponentModel.DataAnnotations;

namespace ConsoleProject.DTOs.RequestModels;

public class UpdateApplication
{
    [Required(ErrorMessage ="Fill in The First Name")]
    public string FirstName{get; set;}
    [Required(ErrorMessage ="Fill in The Last Name")]
    public string LastName {get; set;}
    public string PhoneNumber {get; set;}
    public string Nationality {get; set;}
    public string CurrentResidence {get; set;}
}
