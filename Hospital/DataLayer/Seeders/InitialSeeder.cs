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
                    Description = "Our Internal Medicine department specializes in the prevention, diagnosis, and treatment of adult diseases. Our team of experienced internists provides comprehensive care for a wide range of conditions, including chronic illnesses such as diabetes, hypertension, heart disease, and respiratory disorders.",
                    Img = "Specializations/internal_medicine.jpg",
                    Slug = "InternalMedicine"
                },

                new Specialization()
                {
                    Id = 2,
                    Name = "Pediatrics",
                    Description = "At our clinic, we offer specialized pediatric care designed to support the health and development of children from infancy through adolescence. Our experienced pediatricians provide comprehensive medical services, including routine check-ups, vaccinations, developmental screenings, treatment of common childhood illnesses, and guidance for parents on nutrition, growth, and behavior.",
                    Img = "Specializations/pediatrics.jpg",
                    Slug = "Pediatrics",
                },

                new Specialization()
                {
                    Id = 3,
                    Name = "Surgery",
                    Description = "Our surgical department is committed to delivering safe, effective, and compassionate care to patients in need of surgical treatment. We offer a wide range of surgical services—from minor procedures to complex operations—performed by skilled surgeons using the latest techniques and technology.",
                    Img = "Specializations/surgery.png",
                    Slug = "Surgery",
                }
            );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor()
                {
                    Id = 1,
                    SpecializationId = 1,
                    Name = "Ibrahim Awad",
                    Img = "Doctors/doctor1.jpg",
                    Description = "Dr. Ibrahim Awad is a specialist in Internal Medicine with over 10 years of experience in treating various medical conditions. He is known for his patient-centered approach and dedication to improving health outcomes.",
                    
                },

                new Doctor()
                {
                    Id = 2,
                    SpecializationId = 1,
                    Name = "Ahmed Essawy",
                    Img = "Doctors/doctor2.jpg",
                    Description = "Dr. Ahmed Essawy is a renowned Internal Medicine specialist with a focus on chronic disease management. He has a passion for educating patients about their health and empowering them to take control of their well-being.",
                },

                new Doctor()
                {
                    Id = 3,
                    SpecializationId = 2,
                    Name = "Mohamed Ali",
                    Img = "Doctors/doctor4.jpg",
                    Description = "Dr. Mohamed Ali is a dedicated Pediatrician with a love for working with children. He has extensive experience in diagnosing and treating childhood illnesses, and he is committed to providing compassionate care to his young patients."
                },

                new Doctor()
                {
                    Id = 4,
                    SpecializationId = 2,
                    Name = "Nader Hamdy",
                    Img = "Doctors/doctor6.jpg",
                    Description = "Dr. Nader Hamdy is a Pediatric specialist with a focus on developmental disorders. He works closely with families to ensure the best possible outcomes for children with special needs."
                },

                new Doctor()
                {
                    Id = 5,
                    SpecializationId = 2,
                    Name = "Mohamed Zaky",
                    Img = "Doctors/doctor2.jpg",
                    Description = "Dr. Mohamed Zaky is a Pediatrician with a passion for child health and wellness. He believes in a holistic approach to healthcare, addressing both physical and emotional needs of his young patients."
                }
            );


            modelBuilder.Entity<DoctorSchedule>().HasData(
                new DoctorSchedule()
                {
                    Id = 1,
                    DoctorId = 1,
                    DayName = (DaysName)DayOfWeek.Monday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0)
                },
                new DoctorSchedule()
                {
                    Id = 2,
                    DoctorId = 1,
                    DayName = (DaysName)DayOfWeek.Tuesday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0)
                },
                new DoctorSchedule()
                {
                    Id = 3,
                    DoctorId = 1,
                    DayName = (DaysName)DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0)
                },
                new DoctorSchedule()
                {
                    Id = 4,
                    DoctorId = 1,
                    DayName = (DaysName)DayOfWeek.Thursday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0)
                },
                new DoctorSchedule()
                {
                    Id = 5,
                    DoctorId = 1,
                    DayName = (DaysName)DayOfWeek.Sunday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0)
                },

                new DoctorSchedule()
                {
                    Id = 6,
                    DoctorId = 2,
                    DayName = (DaysName)DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0)
                },

                new DoctorSchedule()
                {
                    Id = 7,
                    DoctorId = 2,
                    DayName = (DaysName)DayOfWeek.Sunday,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0)
                },

                new DoctorSchedule()
                {
                    Id = 8,
                    DoctorId = 2,
                    DayName = (DaysName)DayOfWeek.Monday,
                    StartTime = new TimeSpan(17, 0, 0),
                    EndTime = new TimeSpan(23, 0, 0)
                },

                new DoctorSchedule()
                {
                    Id = 9,
                    DoctorId = 3,
                    DayName = (DaysName)DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(17, 0, 0)
                },

                new DoctorSchedule()
                {
                    Id = 10,
                    DoctorId = 4,
                    DayName = (DaysName)DayOfWeek.Monday,
                    StartTime = new TimeSpan(7, 0, 0),
                    EndTime = new TimeSpan(18, 0, 0)
                },

                new DoctorSchedule()
                {
                    Id = 11,
                    DoctorId = 4,
                    DayName = (DaysName)DayOfWeek.Sunday,
                    StartTime = new TimeSpan(7, 0, 0),
                    EndTime = new TimeSpan(18, 0, 0)
                },
                new DoctorSchedule()
                {
                    Id = 12,
                    DoctorId = 5,
                    DayName = (DaysName)DayOfWeek.Tuesday,
                    StartTime = new TimeSpan(7, 0, 0),
                    EndTime = new TimeSpan(18, 0, 0)
                },

                new DoctorSchedule()
                {
                    Id = 13,
                    DoctorId = 5,
                    DayName = (DaysName)DayOfWeek.Monday,
                    StartTime = new TimeSpan(7, 0, 0),
                    EndTime = new TimeSpan(18, 0, 0)
                }

            );

        }
    }
}
