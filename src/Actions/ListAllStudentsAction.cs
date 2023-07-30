using StudentManagementSystem.Data;

namespace StudentManagementSystem.Actions;

public class ListAllStudentsAction : ActionBase
{
    public override string Name => "List all students";

    public override void Run()
    {
        using var context = new StudentContext();
        var students = context.Students.ToList();
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Id} - {student.Name} - {student.Age} years old - Grade {student.Grade}");
        }
    }
}
