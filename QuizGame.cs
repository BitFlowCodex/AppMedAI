using AppMedAI;

public class QuizGame
{
  // AI-inspired: I used fields to store the questions and the player's score
  private readonly List<Question> _questions;
  private int _score;

  public QuizGame(List<Question> questions)
  {
    _questions = questions;
    _score = 0;
  }

  // AI-inspired: I used a loop to ask every question in the list
  // I kept this structure and used Swedish messages for the player
  public void Start()
  {
    foreach (Question question in _questions)
    {
      AskQuestion(question);
    }

    Console.WriteLine($"Quizzen är klar! Du fick {_score} av {_questions.Count} poäng.");
  }

  private void AskQuestion(Question question)
  {
    Console.WriteLine(question.Text);

    for (int i = 0; i < question.Answers.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {question.Answers[i]}");
    }

    Console.Write("Skriv numret på ditt svar: ");
    string? userInput = Console.ReadLine();

    if (int.TryParse(userInput, out int answerNumber))
    {
      if (answerNumber - 1 == question.CorrectAnswerIndex)
      {
        Console.WriteLine("Rätt svar!");
        _score++;
      }
      else
      {
        Console.WriteLine("Fel svar.");
      }
    }
    else
    {
      Console.WriteLine("Ogiltigt svar. Du får ingen poäng för frågan.");
    }
  }
}