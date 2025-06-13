using DataLayer.Models;
using DataLayer.Seeders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Hospital; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

       public DbSet<Specialization> Specializations { get; set; }
       public  DbSet<Doctor> Doctors { get; set; }
       public  DbSet<DoctorSchedule> DoctorSchedules { get; set; }
       public  DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Specialization>().HasIndex(x => x.Slug).IsUnique();
            modelBuilder.Entity<Specialization>().Property(x => x.Description).HasColumnType("text");
            modelBuilder.Entity<Doctor>().Property(x => x.ExaminationDuration).HasDefaultValue(30);
            new InitialSeeder(modelBuilder);
        }
    }
}
