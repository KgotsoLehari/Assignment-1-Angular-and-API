using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using u20530545_HW01_API.Models;
using Microsoft.AspNetCore.Identity;


namespace u20530545_HW01_API.Data
{
    public class AppDbContext : DbContext
    {
        // INITIALIZATION
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Put your table here
        public DbSet<Course> Courses { get; set; }

        //Constructor method

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Course
            //Seed dummy data

            var data = new Course[]
            {
                new Course{courseId = 1 ,
                    courseName = "AIM 101" ,
                    courseDuration = "Duration: Semester",
                    courseDescription = "Description: Year 1 , Semester 1 , Academic Information Management"
                } ,
                 new Course{courseId = 2 ,
                    courseName = "FRK 113" ,
                    courseDuration = "Duration: Semester 1" ,
                    courseDescription = "Description: Accounting Principles"
                } ,
                  new Course{courseId = 3 ,
                    courseName = "INF 200" ,
                    courseDuration = "Duration: Year" ,
                    courseDescription = "Description: Introduction to API's"
                } ,
                   new Course{courseId = 4 ,
                    courseName = "INF 345" ,
                    courseDuration = "Duration: Year" ,
                    courseDescription = "Description: Advanced Programming"
                },
                    new Course{courseId = 5 ,
                    courseName = "INF 200" ,
                    courseDuration = "Duration: Year" ,
                    courseDescription = "Description: Taxonomies"
                } ,
                     new Course{courseId = 6 ,
                    courseName = "INF 345" ,
                    courseDuration = "Duration: Semester" ,
                    courseDescription = "Description: Year 2 , Semester 1 , Academic Information Management"
                } ,

                    new Course{courseId = 7 ,
                    courseName = "INF 370" ,
                    courseDuration = "Duration: Year" ,
                    courseDescription = "Description: Year 3. Project"
                } ,
                    new Course{courseId = 8 ,
                    courseName = "INF 354" ,
                    courseDuration = "Duration: Semester 1" ,
                    courseDescription = "Description: Introduction to API's"
                } ,

                    new Course{courseId = 9 ,
                    courseName = "INF 324" ,
                    courseDuration = "Duration: Semester" ,
                    courseDescription = "Description: Year 3 , Semester 2 , IT Trends"
                } ,

                    new Course{courseId = 10 ,
                    courseName = "INF 315" ,
                    courseDuration = "Duration: Semester" ,
                    courseDescription = "Description: Year 3 , Semester 1 . Programming Management"
                } ,
            };

            builder.Entity<Course>().HasData(data);

        }

    }
}
