namespace ConsoleProject.Models
{
    // Profile represents a class that holds information about an applicant's profile.
    public class Profile
    {
        // EducationProfile holds information related to the applicant's education profile.
        public EducationProfile EducationProfile { get; set; }

        // ProfessionalProfile holds information related to the applicant's professional profile.
        public ProfessionalProfile ProfessionalProfile { get; set; }

        // Resume represents the resume associated with the applicant's profile.
        public Resume Resume { get; set; }
    }
}
