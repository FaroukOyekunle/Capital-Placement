using ConsoleProject.Models; 

namespace ConsoleProject.DTOs.RequestModels
{
    // UpdateProgram class represents the data transfer object (DTO) used for updating an existing program
    public class UpdateProgram
    {
        // Benefits property represents a list of benefits offered by the program
        public List<string> Benefits { get; set; }

        // ApplicationCriteria property represents a list of criteria for application
        public List<string> ApplicationCriteria { get; set; }

        // ProgramLocations property represents a list of locations where the program takes place
        public List<ProgramLocation> ProgramLocations { get; set; }
    }
}
