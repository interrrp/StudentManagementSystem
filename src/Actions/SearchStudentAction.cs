using StudentManagementSystem.UI;
using StudentManagementSystem.Data;

namespace StudentManagementSystem.Actions;

public class SearchStudentAction : ActionBase
{
    public override string Name => "Search for a student";

    public SearchStudentAction(StudentContext context)
        : base(context) { }

    public override void Run()
    {
        var questions = new QuestionList();
        questions.Add("Name");

        var answers = questions.Ask();

        var students = Context.Students.Where(s => s.Name.Contains(answers["Name"]!)).ToList();
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Id} - {student.Name} - {student.Age} years old - Grade {student.Grade}");
        }

        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
        }

        Console.ReadKey(true);
    }
}
