using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codedal
{
    public class Student
    {
        [Key]
        [Required]
        public int RollNo { get; set; }
        [MaxLength(20, ErrorMessage = "Can't greater than 20")]
        [MinLength(2, ErrorMessage = "Can't greater than 2")]
        public string Name { get; set; }
        public string City { get; set; }

        public virtual ICollection<Student> Studentslist { get; set; }

    }
    public class Course
    {
        [Key]
        [Required]
        public int Courseid { get; set; }
        [MaxLength(15, ErrorMessage = "Can't greater than 20")]
        [MinLength(2, ErrorMessage = "Can't greater than 2")]
        public string Coursename { get; set; }
        public virtual ICollection<Course> Courseslist { get; set; }
    }
    public class enrol
    {
        [Key]
        [Required]
        public int enrolno { get; set; }
        
        public int RollNo { get; set; }
       
        public int Courseid { get; set; }
        public double CourseCost { get; set; }
        public ICollection<enrol> GetEnrols
        {
            get;
            set;
        }
        [ForeignKey("RollNo")]
        public virtual Student Studentdetails { get; set; }
        [ForeignKey("Courseid")]
        public virtual Course Coursedetails { get; set; }

    }
    public class MyContext:DbContext{
        public MyContext() : base("MyContext")
        {
            Database.SetInitializer<MyContext>(new CreateDatabaseIfNotExists<MyContext>());
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<enrol> enrols { get; set; }



    }
}
