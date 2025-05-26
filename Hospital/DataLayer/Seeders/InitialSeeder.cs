using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Seeders
{
    public class InitialSeeder
    {
        public InitialSeeder(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Specialization>().HasData(
                new Specialization()
                {
                    Id = 1,
                    Name = "Internal Medicine",
                    Description = "Description About Internal Medicine",
                    Slug = "InternalMedicine"
                },

                new Specialization()
                {
                    Id = 2,
                    Name = "Pediatrics",
                    Description = "Description About Pediatrics",
                    Slug = "Pediatrics",
                },

                new Specialization()
                {
                    Id = 3,
                    Name = "Surgery",
                    Description = "Description About Surgery",
                    Slug = "Surgery",
                }
            );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor()
                {
                    Id = 1,
                    SpecializationId = 1,
                    Name = "Ibrahim Awad",
                    Img = "Doctors/doctor1.jpg"
                },

                new Doctor()
                {
                    Id = 2,
                    SpecializationId = 1,
                    Name = "Ahmed Essawy",
                    Img = "Doctors/doctor2.jpg"
                },

                new Doctor()
                {
                    Id = 3,
                    SpecializationId = 2,
                    Name = "Mohamed Ali",
                    Img = "Doctors/doctor4.jpg"
                },

                new Doctor()
                {
                    Id = 4,
                    SpecializationId = 2,
                    Name = "Nader Hamdy",
                    Img = "Doctors/doctor6.jpg"
                },

                new Doctor()
                {
                    Id = 5,
                    SpecializationId = 2,
                    Name = "Mohamed Zaky",
                    Img = "Doctors/doctor2.jpg"
                }
            );

        }
    }
}
