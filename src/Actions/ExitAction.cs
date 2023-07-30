namespace StudentManagementSystem.Actions;

public class ExitAction : ActionBase
{
    public override string Name => "Exit";

    public override void Run()
    {
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }
}
