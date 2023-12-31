using StudentManagementSystem.UI;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Actions;

public class AddStudentAction : ActionBase
{
    public override string Name => "Add a student";

    public AddStudentAction(StudentContext context)
        : base(context) { }

    public override void Run()
    {
        var questions = new QuestionList();
        questions.Add("Name");
        questions.Add("Age");
        questions.Add("Grade");

        var answers = questions.Ask();

        var student = new Student
        {
            Name = answers["Name"]!,
            Age = int.Parse(answers["Age"]!),
            Grade = int.Parse(answers["Grade"]!)
        };

        Context.Students.Add(student);
        Context.SaveChanges();

        Console.WriteLine("Student added.");
        Thread.Sleep(1000);
    }
}
