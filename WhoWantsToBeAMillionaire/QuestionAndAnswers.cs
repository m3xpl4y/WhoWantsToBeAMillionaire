namespace WhoWantsToBeAMillionaire
{
    public static class QuestionAndAnswers
    {
        public static QuizQuestion Question(string question)
        {
            return new QuizQuestion(question);
        }

        public static List<QuizAnswer> Answers(QuizAnswer answer1, QuizAnswer answer2, QuizAnswer answer3, QuizAnswer answer4)
        {
            return new List<QuizAnswer>()
            {
                answer1, answer2, answer3, answer4
            };
        }

        public static List<Quiz> Quizzes()
        {
            var quiz1 = new Quiz()
            {
                QuizQuestion = Question("Beim Einbruch in den Kiosk wurde von den Schokoriegeln nur die Hälfte, die Kartoffelchips aber ...?"),
                QuizAnswers = Answers(
                                        new QuizAnswer("fux, du hast die", false),
                                        new QuizAnswer("ganz gestohlen", true),
                                        new QuizAnswer("gib sie", false),
                                        new QuizAnswer("wider her", false))
            };
            var quiz2 = new Quiz()
            {
                QuizQuestion = Question("Was erhält man gegen eine Extra-Gebühr?"),
                QuizAnswers = Answers(
                            new QuizAnswer("Wunscheinkommenssteuer", false),
                            new QuizAnswer("Wunschpersonalausweis", false),
                            new QuizAnswer("Wunschkennzeichen", true),
                            new QuizAnswer("Wunschabitur", false))
            };
            var quiz3 = new Quiz()
            {
                QuizQuestion = Question("Wenn der Tyrannosaurus im „Jurassic Park“ für Recht und Ordnung sorgen würde, wäre er quasi der ...?"),
                QuizAnswers = Answers(
                            new QuizAnswer("Detektiv Rockford", false),
                            new QuizAnswer("Kommissar Rex", true),
                            new QuizAnswer("Inspektor Barnaby", false),
                            new QuizAnswer("Hausmeister Krause", false))
            };
            var quiz4 = new Quiz()
            {
                QuizQuestion = Question("Wer auf Phuket im Wonnemonat zur Begrüßung „Sawatdi krab“ sagt, sprich im ...?"),
                QuizAnswers = Answers(
                            new QuizAnswer("Tequila Sunrize", false),
                            new QuizAnswer("Cuba Liebre", false),
                            new QuizAnswer("Piña Kolada", false),
                            new QuizAnswer("Mai Thai", true))
            };
            var quiz5 = new Quiz()
            {
                QuizQuestion = Question("Hat eine Fußballmannschaft nichts entgegenzusetzen, wird sie vom gegnerischen Sturm zumindest laut Reporterjargon ...?"),
                QuizAnswers = Answers(
                            new QuizAnswer("vom Platz gefegt", true),
                            new QuizAnswer("aus dem Stadion geschrubbt", false),
                            new QuizAnswer("vom Spielfeld gewischt", false),
                            new QuizAnswer("vom Rasen gekehrt", false))
            };
            return new List<Quiz> { quiz1, quiz2, quiz3, quiz4, quiz5 };
        }
    }
}
