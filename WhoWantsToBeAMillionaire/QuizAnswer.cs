namespace WhoWantsToBeAMillionaire
{
    public class QuizAnswer
    {
        public string Answer { get; }
        public bool IsCorrectAnswer { get; }

        public QuizAnswer(string answer, bool isCorrectAnswer)
        {
            Answer = answer;
            IsCorrectAnswer = isCorrectAnswer;
        }
    }
}
