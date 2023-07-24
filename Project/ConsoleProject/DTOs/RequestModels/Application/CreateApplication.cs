using System.ComponentModel.DataAnnotations; 
using ConsoleProject.Enums; 
using ConsoleProject.Models; 

namespace ConsoleProject.DTOs.RequestModels
{
    // CreateApplication class represents the data transfer object (DTO) used for creating an application
    public class CreateApplication
    {
        // [Required] attribute ensures that ApplicationCoverImage property must be provided and cannot be null or empty
        [Required(ErrorMessage = "Fill The Application Image")]
        public string ApplicationCoverImage { get; set; }

        // [Required] attribute ensures that FirstName property must be provided and cannot be null or empty
        [Required(ErrorMessage = "Fill in The First Name")]
        public string FirstName { get; set; }

        // [Required] attribute ensures that LastName property must be provided and cannot be null or empty
        [Required(ErrorMessage = "Fill in The Last Name")]
        public string LastName { get; set; }

        // [Required] attribute ensures that EmailAddress property must be provided and cannot be null or empty
        [Required(ErrorMessage = "Fill in The EmailAddress Value")]
        public string EmailAddress { get; set; }

        // PhoneNumber property represents the applicant's phone number
        public string PhoneNumber { get; set; }

        // Nationality property represents the applicant's nationality
        public string Nationality { get; set; }

        // CurrentResidence property represents the applicant's current residence
        public string CurrentResidence { get; set; }

        // IdNumber property represents the applicant's identification number
        public string IdNumber { get; set; }

        // DateOfBirth property represents the applicant's date of birth
        public DateTime DateOfBirth { get; set; }

        // Gender property represents the applicant's gender, which is of custom enum type Gender
        public Gender Gender { get; set; }

        // Profile property represents the applicant's profile, which is of custom model type Profile
        public Profile Profile { get; set; }

        // ProgramTitle property represents the title of the program for which the application is made
        public string ProgramTitle { get; set; }
    }
}
