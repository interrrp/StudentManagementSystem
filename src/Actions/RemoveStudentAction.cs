using StudentManagementSystem.UI;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Actions;

public class RemoveStudentAction : ActionBase
{
    public override string Name => "Remove a student";

    public RemoveStudentAction(StudentContext context)
        : base(context) { }

    public override void Run()
    {
        var questions = new QuestionList();
        questions.Add("Name");

        var answers = questions.Ask();

        var student = Context.Students.FirstOrDefault(s => s.Name == answers["Name"]);
        if (student is null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        Context.Students.Remove(student);
        Context.SaveChanges();

        Console.WriteLine("Student removed.");
        Thread.Sleep(1000);
    }
}
