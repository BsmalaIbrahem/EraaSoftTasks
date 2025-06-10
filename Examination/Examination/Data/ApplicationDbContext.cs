using Examination.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-A0K6IUH\\SQLEXPRESS;User Id=admin2;Password=33882426;DataBase=Examination;TrustServerCertificate=True");
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<GradeLevel> GradeLevels { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentExam> StudentExams { get; set; }
        public DbSet<StudentAnswer> StudentAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentExam>().HasKey(e => new {e.ExamId, e.StudentId});
           modelBuilder.Entity<StudentAnswer>().HasKey(e => new {e.OptionId, e.StudentId});
        }
    }
}
