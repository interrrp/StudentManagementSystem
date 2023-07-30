namespace StudentManagementSystem.Actions;

public abstract class ActionBase
{
    public abstract string Name { get; }
    public override string ToString() => Name;
    public abstract void Run();
}
