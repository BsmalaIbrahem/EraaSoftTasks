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
            optionsBuilder.UseSqlServer("Server=DESKTOP-A0K6IUH\\SQLEXPRESS;User Id=admin2;Password=33882426;DataBase=Hospital;TrustServerCertificate=True");
        }

       public DbSet<Specialization> Specializations { get; set; }
       public  DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Specialization>().HasIndex(x => x.Slug).IsUnique();
            modelBuilder.Entity<Specialization>().Property(x => x.Description).HasColumnType("text");
            new InitialSeeder(modelBuilder);
        }
    }
}
