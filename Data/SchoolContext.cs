using University.Models;
using Microsoft.EntityFrameworkCore;
using University.Data;
using Microsoft.AspNetCore.Http;

namespace University.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }
        public DbSet<Teaches> Teaches { get; set; }
        public DbSet<Advisor> Advisors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourses>()
               .HasKey(c => new { c.CourseID, c.StudentID });
            modelBuilder.Entity<Teaches>()
               .HasKey(c => new { c.CourseID, c.TeacherID });
        }
    }
}