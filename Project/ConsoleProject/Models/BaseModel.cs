using System.ComponentModel.DataAnnotations;

namespace ConsoleProject.Models
{
    // BaseModel is an abstract class representing the base model for entities.
    public abstract class BaseModel
    {
        // Id represents the unique identifier for the entity and is marked as the Key.
        [Key]
        public string Id { get; private set; } = Guid.NewGuid().ToString();
    }

    // ProfileBase is an abstract class representing the base model for profile-related entities.
    public abstract class ProfileBase
    {
        // Mandatory indicates whether the profile attribute is mandatory or not.
        public bool Mandatory { get; set; }

        // Hidden indicates whether the profile attribute should be hidden or not.
        public bool Hidden { get; set; }
    }
}
