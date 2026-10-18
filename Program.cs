namespace AppMedAI
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Question question = new Question(
        text: "What is 7 + 7?",
        answers: new List<string> { "12", "17", "19", "14" },
        correctAnswerIndex: 3
      );

      List<Question> questions = new List<Question> { question };

      QuizGame game = new QuizGame(questions);
      game.Start();
    }
  }
}
