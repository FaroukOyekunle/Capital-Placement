using ConsoleProject.Enums; 
using ConsoleProject.Models; 

namespace ConsoleProject.DTOs.RetrievalModels
{
    // ApplicationModel represents the data transfer object (DTO) for an application retrieval model.
    public class ApplicationModel
    {
        // FirstName property holds the first name of the applicant.
        public string FirstName { get; set; }

        // LastName property holds the last name of the applicant.
        public string LastName { get; set; }

        // EmailAddress property holds the email address of the applicant.
        public string EmailAddress { get; set; }

        // PhoneNumber property holds the phone number of the applicant.
        public string PhoneNumber { get; set; }

        // ApplicationCoverImage property holds the cover image of the application.
        public string ApplicationCoverImage { get; set; }

        // Nationality property holds the nationality of the applicant.
        public string Nationality { get; set; }

        // CurrentResidence property holds the current residence address of the applicant.
        public string CurrentResidence { get; set; }

        // IdNumber property holds the identification number of the applicant.
        public string IdNumber { get; set; }

        // Gender property represents the gender of the applicant. It uses the Gender enumeration.
        public Gender Gender { get; set; }

        // Profile property holds the applicant's profile information. It uses the Profile class from the Models namespace.
        public Profile Profile { get; set; }
    }
}
