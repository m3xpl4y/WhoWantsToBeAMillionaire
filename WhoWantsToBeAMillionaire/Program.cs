namespace WhoWantsToBeAMillionaire
{
    public static class Program
    {
        private static readonly QuizService _quizService = new();
        public static void Main(string[] args)
        {
            Console.WriteLine("Wer wird Millionär?");
            Console.WriteLine("Zum starten Enter drücken");
            Console.ReadKey();

            var index = 0;
            while (index < QuestionAndAnswers.Quizzes().Count)
            {
                index++;
                _quizService.Print();
                if (index < QuestionAndAnswers.Quizzes().Count)
                {
                    Console.WriteLine("Enter drücken für die nächste Frage");
                    Console.ReadKey();
                }
            }
        }
    }
}
