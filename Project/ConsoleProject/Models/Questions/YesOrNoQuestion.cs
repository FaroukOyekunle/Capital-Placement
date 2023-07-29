namespace ConsoleProject.Models
{
    // YesOrNoQuestion represents a class that holds information about a yes or no question.
    public class YesOrNoQuestion
    {
        // Choice indicates whether the applicant chose "Yes" (true) or "No" (false) as the response.
        public bool Choice { get; set; }

        // DisqualifyForNoChoice is a flag that indicates whether the applicant should be disqualified
        // if they choose "No" as the response. If true, selecting "No" leads to disqualification.
        public bool DisqualifyForNoChoice { get; set; }

        // QuestionId stores the unique identifier of the question to which this YesOrNoQuestion belongs.
        public Guid QuestionId { get; set; }

        // Question is a navigation property that references the actual Question object
        // to which this YesOrNoQuestion is associated.
        public Question Question { get; set; }
    }
}
