using ContosoU2018.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2018.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // EnsureCreated method will automatically create the database if it doesn't already exist. 
            context.Database.EnsureCreated();

            // first, look for any students
            if (context.Students.Any())
            {
                return; 
            }
            var students = new Student[]
            {
                new Student
                {
                    FirstName = "Carson",
                    LastName = "Alexander",
                    Email = "calexander@contoso.com",
                    EnrollmentDate = DateTime.Parse("2017-09-01"),
                    Address = "4 Flanders Court",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E1C 0K6"
                },
                new Student
                {
                    FirstName = "Meridith",
                    LastName = "Alonso",
                    Email = "malonso@contoso.com",
                    EnrollmentDate = DateTime.Parse("2017-09-01"),
                    Address = "205 Argyle Street",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E1C 8V2"
                }
            };

            foreach (Student s in students)
            {
                context.Students.Add(s);
            }

            context.SaveChanges();

            // second, we check for instructors
            var instructors = new Instructor[]
            {
                new Instructor
                {
                    FirstName = "Danielle",
                    LastName = "Boudreau",
                    Email = "dboudreau@contoso.com",
                    HireDate = DateTime.Parse("2010-01-31"),
                    Address = "123 Main street",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E1C 3G4"
                },
                new Instructor
                {
                    FirstName = "Patrice",
                    LastName = "Theriault",
                    Email = "ptheriault@contoso.com",
                    HireDate = DateTime.Parse("2010-01-31"),
                    Address = "456 Main street",
                    City = "Moncton",
                    Province = "NB",
                    PostalCode = "E1C 3G4"

                },
            };
            foreach(Instructor i in instructors)
            {
                context.Instructors.Add(i);
            }
            context.SaveChanges();

            // COURSES
            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3},
                new Course{CourseID=4022,Title="MicroEconomics",Credits=3}
            };
            foreach (Course c in courses)
            {
                context.Add(c);
            }
            context.SaveChanges();

            // ENROLLMENT
            // We need a student ID to assign it to the enrollment "FK"
            var enrollments = new Enrollment[]
            {
                new Enrollment
                {
                    CourseID =1050,
                    StudentID=students.Single(s=>s.LastName=="Alexander").ID,
                    Grade=Grade.A
                },
                new Enrollment
                {
                    CourseID =4022,
                    StudentID=students.Single(s=>s.LastName=="Alonso").ID,
                    Grade=Grade.B
                }
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
