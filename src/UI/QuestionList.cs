namespace StudentManagementSystem.UI;

public class QuestionList
{
    private readonly Dictionary<string, string?> _questions = new();

    public Dictionary<string, string?> Ask()
    {
        var answers = new Dictionary<string, string?>();
        foreach (var question in _questions)
        {
            Console.Write($"{question.Key}: ");
            answers.Add(question.Key, Console.ReadLine());
        }

        return answers;
    }

    public void Add(string question) => _questions.Add(question, null);
}
