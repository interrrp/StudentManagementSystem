using Microsoft.EntityFrameworkCore;

namespace StudentManagementSystem.Data;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Age { get; set; }
    public int Grade { get; set; }
}

public class StudentContext : DbContext
{
    public DbSet<Student> Students { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql("Host=localhost;Database=students;Username=postgres;Password=postgres");
}
