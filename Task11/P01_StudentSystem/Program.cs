using P01_StudentSystem.Data;
using P01_StudentSystem.Models;

namespace P01_StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student()
            {
                Name = "Hams",
                RegisteredOn = DateTime.Now,
            };

            var course = new Course()
            {
                Name = "Course 1",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddHours(150),
                Price = 5000
            };

            ApplicationDbContext context = new ApplicationDbContext();
            context.Students.Add(student);
            context.Courses.Add(course);
            context.SaveChanges();

        }
    }
}
