using StudentManagementSystem.UI;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Actions;

public class RemoveStudentAction : ActionBase
{
    public override string Name => "Remove a student";

    public override void Run()
    {
        var questions = new QuestionList();
        questions.Add("Name");

        var answers = questions.Ask();

        using var context = new StudentContext();
        var student = context.Students.FirstOrDefault(s => s.Name == answers["Name"]);
        if (student is null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        context.Students.Remove(student);
        context.SaveChanges();

        Console.WriteLine("Student removed.");
    }
}
