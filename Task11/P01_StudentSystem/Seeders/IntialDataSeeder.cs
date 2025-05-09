using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Seeders
{
    public class IntialDataSeeder
    {
        public IntialDataSeeder(ModelBuilder modelBuilder) 
        {
            var staticDate = new DateTime(2025, 5, 9, 12, 0, 0);
            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    Name = "Basmala",
                    PhoneNumber = "1234567890",
                    RegisteredOn = staticDate,
                    Birthday = new DateOnly(2001,06,22),
                },

                new Student()
                {
                    Id = 2,
                    Name = "Ghidaa",
                    PhoneNumber = "1234567850",
                    RegisteredOn = staticDate,
                    Birthday = new DateOnly(2002, 05, 25),
                }

            );

            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    Id = 1,
                    Name = "Asp.Net Core",
                    StartDate = staticDate,
                    EndDate = staticDate.AddMonths(5),
                    Price = 7200.50m
                },

                new Course()
                {
                    Id = 2,
                    Name = "Front-End",
                    StartDate = staticDate,
                    EndDate = staticDate.AddMonths(5),
                    Price = 6200.50m
                }
             );


            modelBuilder.Entity<Resource>().HasData(
                new Resource()
                {
                    Id = 1,
                    Name = "Resource 1",
                    Url = "url.com",
                    ResourceType = ResourceType.Document,
                    CourseId = 1,
                },

                new Resource()
                {
                    Id = 2,
                    Name = "Resource 2",
                    Url = "url2.com",
                    ResourceType = ResourceType.Presentation,
                    CourseId = 2,
                },
                new Resource()
                {
                    Id = 3,
                    Name = "Resource 3",
                    Url = "url3.com",
                    ResourceType = ResourceType.Other,
                    CourseId = 2,
                }
             );

            

            modelBuilder.Entity<Homework>().HasData(
                new Homework()
                {
                    Id = 1,
                    Content = "ErraSoft/Tasks/content.pdf",
                    ContentType = ContentType.Pdf,
                    SubmissionTime = staticDate,
                    StudentId = 1,
                    CourseId = 2,
                }
               );

        }
    }
}
