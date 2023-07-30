using StudentManagementSystem.Data;

namespace StudentManagementSystem.Actions;

public abstract class ActionBase
{
    public abstract string Name { get; }
    protected StudentContext Context { get; } = null!;

    public ActionBase() {}
    public ActionBase(StudentContext context) => Context = context;

    public override string ToString() => Name;
    public abstract void Run();
}
