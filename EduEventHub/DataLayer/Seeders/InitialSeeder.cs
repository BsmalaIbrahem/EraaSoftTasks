using DataLayer.Data;
using DataLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer.Seeders
{
    public class InitialSeeder
    {
        public InitialSeeder(ModelBuilder modelBuilder)
        {
            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Workshops", Description = "Hands-on learning sessions" },
                new Category { Id = 2, Name = "Lectures", Description = "Educational talks by experts" },
                new Category { Id = 3, Name = "Exhibitions", Description = "Cultural and scientific displays" },
                new Category { Id = 4, Name = "Conferences", Description = "Multi-day events with multiple speakers" },
                new Category { Id = 5, Name = "Seminars", Description = "Focused discussions on specific topics" }
            );

            // Seed Speakers (all male names)
            modelBuilder.Entity<Speaker>().HasData(
                new Speaker
                {
                    Id = 1,
                    Name = "Ahmed Khaled",
                    Bio = "Software engineering expert with over 10 years of experience.",
                    Specialization = "Software Development",
                    ImgPath = "assets/images/speakers/single-speaker.jpg"
                },
                new Speaker
                {
                    Id = 2,
                    Name = "Mohamed Ali",
                    Bio = "Data science enthusiast and AI researcher.",
                    Specialization = "Data Science",
                    ImgPath = "assets/images/speakers/speaker-five.jpg"
                },
                new Speaker
                {
                    Id = 3,
                    Name = "Omar Mostafa",
                    Bio = "Specialist in educational workshops with a focus on interactive learning.",
                    Specialization = "Education",
                    ImgPath = "assets/images/speakers/speaker-full-five.jpg"
                },
                new Speaker
                {
                    Id = 4,
                    Name = "Hassan Ibrahim",
                    Bio = "Expert in cloud computing and distributed systems.",
                    Specialization = "Cloud Computing",
                    ImgPath = "assets/images/speakers/speaker-full-one.jpg"
                },
                new Speaker
                {
                    Id = 5,
                    Name = "Youssef Sami",
                    Bio = "Cybersecurity specialist with a focus on ethical hacking.",
                    Specialization = "Cybersecurity",
                    ImgPath = "assets/images/speakers/speaker-full-three.jpg"
                }
            );

            // Seed Events (varied dates and categories)
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    Id = 1,
                    Title = "Python Workshop",
                    Description = "A hands-on workshop to learn Python programming from scratch.",
                    CategoryId = 1,
                    ImgPath = "assets/images/gallery/gallery-less-eight.jpg",
                    StartDate = new DateTime(2024, 10, 15, 10, 0, 0, DateTimeKind.Utc),
                    EndDate = new DateTime(2024, 10, 16, 16, 0, 0, DateTimeKind.Utc),
                    Price = 50.0
                },
                new Event
                {
                    Id = 2,
                    Title = "AI Lecture Series",
                    Description = "Explore the future of artificial intelligence with leading experts.",
                    CategoryId = 2,
                    ImgPath = "assets/images/gallery/gallery-full-seven.jpg",
                    StartDate = new DateTime(2025, 1, 20, 14, 0, 0, DateTimeKind.Utc),
                    EndDate = new DateTime(2025, 1, 20, 17, 0, 0, DateTimeKind.Utc),
                    Price = 30.0
                },
                new Event
                {
                    Id = 3,
                    Title = "Tech Exhibition 2025",
                    Description = "Showcasing the latest innovations in technology.",
                    CategoryId = 3,
                    ImgPath = "assets/images/background/cta-ticket-bg.jpg",
                    StartDate = new DateTime(2025, 6, 10, 9, 0, 0, DateTimeKind.Utc),
                    EndDate = new DateTime(2025, 6, 12, 18, 0, 0, DateTimeKind.Utc),
                    Price = 20.0
                },
                new Event
                {
                    Id = 4,
                    Title = "Cloud Computing Conference",
                    Description = "A conference on cloud solutions and scalability.",
                    CategoryId = 4,
                    ImgPath = "assets/images/background/homepage-one-banner.jpg",
                    StartDate = new DateTime(2023, 11, 5, 9, 0, 0, DateTimeKind.Utc),
                    EndDate = new DateTime(2023, 11, 7, 17, 0, 0, DateTimeKind.Utc),
                    Price = 100.0
                },
                new Event
                {
                    Id = 5,
                    Title = "Cybersecurity Seminar",
                    Description = "Learn about the latest trends in cybersecurity.",
                    CategoryId = 5,
                    ImgPath = "assets/images/background/timer-bg.jpg",
                    StartDate = new DateTime(2026, 3, 15, 10, 0, 0, DateTimeKind.Utc),
                    EndDate = new DateTime(2026, 3, 15, 15, 0, 0, DateTimeKind.Utc),
                    Price = 40.0
                }
            );



            modelBuilder.Entity<EventAgenda>().HasData(
                 new EventAgenda
                 {
                     Id = 1,
                     EventId = 1, // Python Workshop
                     Date = new DateTime(2024, 10, 15, 0, 0, 0, DateTimeKind.Utc)
                 },
                 new EventAgenda
                 {
                     Id = 2,
                     EventId = 1, // Python Workshop (second day)
                     Date = new DateTime(2024, 10, 16, 0, 0, 0, DateTimeKind.Utc)
                 },
                 new EventAgenda
                 {
                     Id = 3,
                     EventId = 2, // AI Lecture Series
                     Date = new DateTime(2025, 1, 20, 0, 0, 0, DateTimeKind.Utc)
                 },
                 new EventAgenda
                 {
                     Id = 4,
                     EventId = 3, // Tech Exhibition 2025 (first day)
                     Date = new DateTime(2025, 6, 10, 0, 0, 0, DateTimeKind.Utc)
                 },
                 new EventAgenda
                 {
                     Id = 5,
                     EventId = 3, // Tech Exhibition 2025 (second day)
                     Date = new DateTime(2025, 6, 11, 0, 0, 0, DateTimeKind.Utc)
                 },
                 new EventAgenda
                 {
                     Id = 6,
                     EventId = 4, // Cloud Computing Conference
                     Date = new DateTime(2023, 11, 5, 0, 0, 0, DateTimeKind.Utc)
                 },
                 new EventAgenda
                 {
                     Id = 7,
                     EventId = 5, // Cybersecurity Seminar
                     Date = new DateTime(2026, 3, 15, 0, 0, 0, DateTimeKind.Utc)
                 }
             );

            // Seed EventContent (sessions within each agenda)
            modelBuilder.Entity<EventContent>().HasData(
                new EventContent
                {
                    Id = 1,
                    EventAgendaId = 1, // Python Workshop, Day 1
                    SpeakerId = 1, // Ahmed Khaled
                    Subject = "Introduction to Python Programming",
                    StartTime = new TimeOnly(10, 0)
                },
                new EventContent
                {
                    Id = 2,
                    EventAgendaId = 1, // Python Workshop, Day 1
                    SpeakerId = 3, // Omar Mostafa
                    Subject = "Python for Data Science",
                    StartTime = new TimeOnly(14, 0)
                },
                new EventContent
                {
                    Id = 3,
                    EventAgendaId = 2, // Python Workshop, Day 2
                    SpeakerId = 1, // Ahmed Khaled
                    Subject = "Advanced Python Techniques",
                    StartTime = new TimeOnly(11, 0)
                },
                new EventContent
                {
                    Id = 4,
                    EventAgendaId = 3, // AI Lecture Series
                    SpeakerId = 2, // Mohamed Ali
                    Subject = "Machine Learning Fundamentals",
                    StartTime = new TimeOnly(14, 0)
                },
                new EventContent
                {
                    Id = 5,
                    EventAgendaId = 3, // AI Lecture Series
                    SpeakerId = 4, // Hassan Ibrahim
                    Subject = "AI in Cloud Computing",
                    StartTime = new TimeOnly(16, 0)
                },
                new EventContent
                {
                    Id = 6,
                    EventAgendaId = 4, // Tech Exhibition 2025, Day 1
                    SpeakerId = 1, // Ahmed Khaled
                    Subject = "Innovations in Software Development",
                    StartTime = new TimeOnly(9, 30)
                },
                new EventContent
                {
                    Id = 7,
                    EventAgendaId = 4, // Tech Exhibition 2025, Day 1
                    SpeakerId = 2, // Mohamed Ali
                    Subject = "AI-Powered Innovations",
                    StartTime = new TimeOnly(13, 0)
                },
                new EventContent
                {
                    Id = 8,
                    EventAgendaId = 5, // Tech Exhibition 2025, Day 2
                    SpeakerId = 4, // Hassan Ibrahim
                    Subject = "Cloud Solutions Showcase",
                    StartTime = new TimeOnly(10, 0)
                },
                new EventContent
                {
                    Id = 9,
                    EventAgendaId = 6, // Cloud Computing Conference
                    SpeakerId = 4, // Hassan Ibrahim
                    Subject = "Scalable Cloud Architectures",
                    StartTime = new TimeOnly(9, 0)
                },
                new EventContent
                {
                    Id = 10,
                    EventAgendaId = 6, // Cloud Computing Conference
                    SpeakerId = 5, // Youssef Sami
                    Subject = "Securing Cloud Infrastructure",
                    StartTime = new TimeOnly(11, 30)
                },
                new EventContent
                {
                    Id = 11,
                    EventAgendaId = 7, // Cybersecurity Seminar
                    SpeakerId = 5, // Youssef Sami
                    Subject = "Ethical Hacking Techniques",
                    StartTime = new TimeOnly(10, 0)
                }
            );

            // Seed SpeakerSocialMedia
            modelBuilder.Entity<SpeakerSocialMedia>().HasData(
                new SpeakerSocialMedia
                {
                    Id = 1,
                    SpeakerId = 1,
                    Platform = PlatForm.LinkedIn,
                    Url = "https://linkedin.com/in/ahmedkhaled"
                },
                new SpeakerSocialMedia
                {
                    Id = 2,
                    SpeakerId = 1,
                    Platform = PlatForm.Twitter,
                    Url = "https://twitter.com/ahmedkhaled"
                },
                new SpeakerSocialMedia
                {
                    Id = 3,
                    SpeakerId = 2,
                    Platform = PlatForm.Twitter,
                    Url = "https://twitter.com/mohamedali"
                },
                new SpeakerSocialMedia
                {
                    Id = 4,
                    SpeakerId = 3,
                    Platform = PlatForm.Instagram,
                    Url = "https://instagram.com/omarmostafa"
                },
                new SpeakerSocialMedia
                {
                    Id = 5,
                    SpeakerId = 4,
                    Platform = PlatForm.LinkedIn,
                    Url = "https://linkedin.com/in/hassanibrahim"
                },
                new SpeakerSocialMedia
                {
                    Id = 6,
                    SpeakerId = 5,
                    Platform = PlatForm.Twitter,
                    Url = "https://twitter.com/youssefsami"
                }
            );

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "1",
                    UserName = "SuperAdmin",
                    NormalizedUserName = "SUPERADMIN",
                    PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "SuperAdmin123!"),
                    Email = "super@gmail.com",
                    NormalizedEmail = "super@gmail.com",
                    EmailConfirmed = true,
                    FirstName = "Super",
                    LastName = "Admin",
                });

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "SuperAdmin",
                    NormalizedName = "SUPERADMIN"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "User",
                    NormalizedName = "USER"
                }
                );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1", 
                    RoleId = "1" 
                }
            );
        }
    }
}