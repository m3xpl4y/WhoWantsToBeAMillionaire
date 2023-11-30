namespace WhoWantsToBeAMillionaire
{
    public class Quiz
    {
        public QuizQuestion QuizQuestion { get; set; }
        public List<QuizAnswer> QuizAnswers { get; set; }

        public Quiz(QuizQuestion quizQuestion, List<QuizAnswer> quizAnswers)
        {
            QuizQuestion = quizQuestion;
            QuizAnswers = quizAnswers;
        }
        public Quiz()
        {
        }
    }
}
