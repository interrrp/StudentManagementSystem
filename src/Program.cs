using StudentManagementSystem.UI;
using StudentManagementSystem.Actions;
using StudentManagementSystem.Data;

namespace StudentManagementSystem;

public class Program
{
    public static void Main()
    {
        Console.Clear();

        using var context = new StudentContext();

        var actions = new ActionMenu<ActionBase>();
        actions.Add(new AddStudentAction(context));
        actions.Add(new RemoveStudentAction(context));
        actions.Add(new SearchStudentAction(context));
        actions.Add(new ListAllStudentsAction(context));
        actions.Add(new EditStudentAction(context));
        actions.Add(new ExitAction());
        
        var choice = actions.Ask();
    
        Console.Clear();
        choice.Run();

        Main();
    }
}
