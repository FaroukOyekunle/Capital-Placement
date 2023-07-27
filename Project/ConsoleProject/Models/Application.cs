using ConsoleProject.Enums;
using System.ComponentModel.DataAnnotations;

namespace ConsoleProject.Models
{
    // Application represents a class that holds information about an application.
    public class Application : BaseModel
    {
        // FirstName represents the first name of the applicant.
        public string FirstName { get; set; }

        // LastName represents the last name of the applicant.
        public string LastName { get; set; }

        // EmailAddress represents the email address of the applicant.
        public string EmailAddress { get; set; }

        // PhoneNumber represents the phone number of the applicant.
        public string PhoneNumber { get; set; }

        // ApplicationCoverImage stores the path to the application cover image.
        public string ApplicationCoverImage { get; set; }

        // Nationality represents the nationality of the applicant.
        public string Nationality { get; set; }

        // CurrentResidence represents the current residence of the applicant.
        public string CurrentResidence { get; set; }

        // IdNumber represents the identification number of the applicant.
        public string IdNumber { get; set; }

        // DateOfBirth represents the date of birth of the applicant.
        public DateTime DateOfBirth { get; set; }

        // StageId is the foreign key referencing the associated Stage entity.
        public string StageId { get; set; }

        // Program represents the associated Program entity for the application.
        public ConsoleProject.Models.Program Program { get; set; }

        // ProgramId is the foreign key referencing the associated Program entity.
        public string ProgramId { get; set; }

        // Gender represents the gender of the applicant (e.g., Male, Female).
        public Gender Gender { get; set; }

        // Profile represents additional profile information of the applicant.
        public Profile Profile { get; set; }

        // Stage represents the associated Stage entity for the application.
        public Stage Stage { get; set; }
    }
}
