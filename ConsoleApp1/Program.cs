

using ConsoleApp1.DataContext;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
var ConnectionString = "Server=Localhost;Port=5432;Database=StudentPortal;User Id=postgres;Password=Vyshu@1999;";
try
{
    var optionsBuilder = new DbContextOptionsBuilder<StudentDataContext>();
    optionsBuilder.UseNpgsql(ConnectionString);

    using (var context = new StudentDataContext(optionsBuilder.Options))
    {
        var students = context.students.ToList();
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.id}, Name: {student.name}, Email: {student.email}");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}