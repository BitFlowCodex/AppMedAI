namespace AppMedAI
{
  public class Question
  {
    // AI-inspired: I used get-only properties so the question data can be read
    // during the quiz but cannot be reassigned after the object is created.
    public string Text { get; }
    public List<string> Answers { get; }
    public int CorrectAnswerIndex { get; }

    public Question(string text, List<string> answers, int correctAnswerIndex)
    {
      Text = text;
      Answers = answers;
      CorrectAnswerIndex = correctAnswerIndex;
    }
  }
}