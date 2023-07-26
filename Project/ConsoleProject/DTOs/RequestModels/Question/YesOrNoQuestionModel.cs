namespace ConsoleProject.DTOs.RequestModels
{
    // YesOrNoQuestionModel class represents the data transfer object (DTO) for yes or no questions
    public class YesOrNoQuestionModel
    {
        // Choice property represents the user's choice for the yes or no question (true for yes, false for no)
        public bool Choice { get; set; }

        // DisqualifyForNoChoice property indicates whether selecting 'No' will disqualify the user from further stages
        public bool DisqualifyForNoChoice { get; set; }
    }
}
