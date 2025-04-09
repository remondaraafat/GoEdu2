using GoEdu.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoEdu.Data
{
    public class GoEduContext : IdentityDbContext<ApplicationUser>
    {
        public GoEduContext(DbContextOptions<GoEduContext> opt) : base(opt) { }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecture> lectures { get; set; }
        public DbSet<Enroll> Enrolls { get; set; }
        public DbSet<Attend> Attends { get; set; }
        public DbSet<Comment> Comments { get; set; }
       
        public DbSet<Answer> Answers { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<StudentPerformance> StudentPerformances { get; set; }

        public DbSet<Option> Options { get; set; }
        


    }
}
