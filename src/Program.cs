using StudentManagementSystem.UI;
using StudentManagementSystem.Actions;

namespace StudentManagementSystem;

public class Program
{
    public static void Main()
    {
        Console.Clear();

        var actions = new ActionMenu<ActionBase>();
        actions.Add(new AddStudentAction());
        actions.Add(new RemoveStudentAction());
        actions.Add(new SearchStudentAction());
        actions.Add(new ListAllStudentsAction());
        actions.Add(new ExitAction());
        
        var choice = actions.Ask();
    
        Console.Clear();
        choice.Run();
    }
}
