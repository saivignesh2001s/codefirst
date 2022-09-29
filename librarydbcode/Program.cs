using Codedal;
namespace librarydbcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
           
            context.Courses.Add(new Course { Courseid = 101, Coursename = "Physics" });
            context.Courses.Add(new Course { Courseid = 102, Coursename = "Chemistry" });
            context.Courses.Add(new Course { Courseid = 103, Coursename = "Biology" });
            context.Courses.Add(new Course { Courseid = 104, Coursename = "Maths" });

            context.SaveChanges();
            Console.WriteLine("Done");
            Console.ReadLine();
          
        }
    }
}