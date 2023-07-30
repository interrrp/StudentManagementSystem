namespace StudentManagementSystem.UI;

public class ActionMenu<T>
{
    private readonly List<T> _actions = new();

    public T Ask()
    {
        for (var i = 0; i < _actions.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_actions[i]}");
        }

        Console.Write("Choose an action: ");
        var choiceNum = Console.ReadLine();

        if (int.TryParse(choiceNum, out var choice)
            && choice > 0
            && choice <= _actions.Count)
        {
            return _actions[choice - 1];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid choice. Please try again.");
            return Ask();
        }
    }

    public void Add(T action) => _actions.Add(action);
}
