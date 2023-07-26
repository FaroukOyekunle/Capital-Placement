namespace ConsoleProject.DTOs.RetrievalModels
{
    // PreviewServiceModel represents the data transfer object (DTO) for previewing a service.
    public class PreviewServiceModel
    {
        // ApplicationCoverImage property represents the cover image of the application.
        public string ApplicationCoverImage { get; set; }

        // ProgramModel property represents the service's program model.
        public ProgramModel ProgramModel { get; set; }
    }
}
