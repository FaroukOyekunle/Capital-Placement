namespace ConsoleProject.Enums
{
    // QuestionType enumeration represents different types of questions.
    public enum QuestionType
    {
        // Paragraph type represents a question that requires a paragraph-length response.
        Paragraph = 1,

        // ShortAnswer type represents a question that requires a short textual response.
        ShortAnswer,

        // YesOrNo type represents a question that requires a Yes or No response.
        YesOrNo,

        // Dropdown type represents a question with a predefined list of options to choose from.
        Dropdown,

        // MultipleChoice type represents a question with multiple options, allowing users to choose more than one.
        MultipleChoice,

        // Date type represents a question that requires a date as a response.
        Date,

        // Number type represents a question that requires a numerical response.
        Number,

        // VideoQuestion type represents a question that requires a video-based response.
        VideoQuestion,

        // FileUpload type represents a question that allows users to upload files as a response.
        FileUpload
    }
}
