using StudentManagementSystem.Data;

namespace StudentManagementSystem.Actions;

public class ListAllStudentsAction : ActionBase
{
    public override string Name => "List all students";

    public ListAllStudentsAction(StudentContext context)
        : base(context) { }

    public override void Run()
    {
        var students = Context.Students.ToList();
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Id} - {student.Name} - {student.Age} years old - Grade {student.Grade}");
        }
        Console.ReadKey(true);
    }
}
