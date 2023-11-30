namespace WhoWantsToBeAMillionaire
{
    public class QuizService
    {
        private readonly Random _random = new();


        public void Print()
        {
            var quiz = GetQuestion();
            Console.WriteLine(quiz.QuizQuestion.Question);
            var count = 0;
            foreach (var answers in quiz.QuizAnswers)
            {
                count++;
                Console.WriteLine($"{count}. {answers.Answer}");
            }
            Console.WriteLine("Bitte die Nummer für Ihre Antwort eingeben und Enter drücken");
            var response = Console.ReadLine();
            if (response != null && Response(response, quiz.QuizAnswers))
            {
                Console.WriteLine("Ihre Antwort ist korrekt!");
                return;
            }
            Console.WriteLine("Ihre Antwort ist nicht korrekt!");
        }

        private Quiz GetQuestion()
        {
            var quizzes = QuestionAndAnswers.Quizzes();
            var n = _random.Next(quizzes.Count);
            return quizzes[n];
        }
        private bool Response(string response, List<QuizAnswer> answers)
        {
            switch (response)
            {
                case "1":
                    if (answers[0].IsCorrectAnswer)
                    {
                        return true;
                    }
                    return false;
                case "2":
                    if (answers[2].IsCorrectAnswer)
                    {
                        return true;
                    }
                    return false;
                case "3":
                    if (answers[2].IsCorrectAnswer)
                    {
                        return true;
                    }
                    return false;
                case "4":
                    if (answers[3].IsCorrectAnswer)
                    {
                        return true;
                    }
                    return false;
                default: return false;
            }
        }
    }
}
