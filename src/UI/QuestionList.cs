namespace StudentManagementSystem.UI;

public class QuestionList
{
    private readonly Dictionary<string, string?> _questions = new();

    public Dictionary<string, string?> Ask()
    {
        var answers = new Dictionary<string, string?>();
        foreach (var question in _questions)
        {
            var hasDefaultAnswer = question.Value is not null;

            // Question name (optional default value):
            Console.Write($"{question.Key}{(hasDefaultAnswer ? $" ({question.Value})" : "")}: ");

            var answer = Console.ReadLine();
            if (hasDefaultAnswer && string.IsNullOrWhiteSpace(answer))
            {
                answer = question.Value;
            }
            answers.Add(question.Key, answer);
        }

        return answers;
    }

    public void Add(string question, string? defaultAnswer = null) =>
        _questions.Add(question, defaultAnswer);
}
