using System.ComponentModel.DataAnnotations; 

namespace ConsoleProject.DTOs.RequestModels
{
    // UpdateApplication class represents the data transfer object (DTO) used for updating an application
    public class UpdateApplication
    {
        // [Required] attribute ensures that FirstName property must be provided and cannot be null or empty
        [Required(ErrorMessage = "Fill in The First Name")]
        public string FirstName { get; set; }

        // [Required] attribute ensures that LastName property must be provided and cannot be null or empty
        [Required(ErrorMessage = "Fill in The Last Name")]
        public string LastName { get; set; }

        // PhoneNumber property represents the applicant's updated phone number
        public string PhoneNumber { get; set; }

        // Nationality property represents the applicant's updated nationality
        public string Nationality { get; set; }

        // CurrentResidence property represents the applicant's updated current residence
        public string CurrentResidence { get; set; }
    }
}
