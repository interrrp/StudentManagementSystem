using StudentManagementSystem.UI;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Actions;

public class EditStudentAction : ActionBase
{
    public override string Name => "Edit a student";
    
    public EditStudentAction(StudentContext context)
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

        var editQuestions = new QuestionList();
        editQuestions.Add("Name", student.Name);
        editQuestions.Add("Age", student.Age.ToString());
        editQuestions.Add("Grade", student.Grade.ToString());

        var editAnswers = editQuestions.Ask();

        student.Name = editAnswers["Name"]!;
        student.Age = int.Parse(editAnswers["Age"]!);
        student.Grade = int.Parse(editAnswers["Grade"]!);

        Context.SaveChanges();

        Console.WriteLine("Student edited.");
        Thread.Sleep(1000);
    }
}
