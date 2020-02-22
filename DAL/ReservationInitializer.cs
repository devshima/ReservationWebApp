using ReservationWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationWebApp.DAL
{
    public class ReservationInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ReservationContext>
    {
        protected override void Seed(ReservationContext context)
        {
            var courses = new List<Course>
            {
                new Course{CourseID=1, CourseType=CourseType.A, Name="Basic"},
                new Course{CourseID=2, CourseType=CourseType.B, Name="Advanced"},
                new Course{CourseID=3, CourseType=CourseType.C, Name="Professional"}
            }; 
            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();

            var students = new List<Student>
            {
                new Student{StudentID=1, FirstName="やまおか", LastName="しろう"},
                new Student{StudentID=2, FirstName="くりた", LastName="ゆうこ"}
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var reservations = new List<Reservation>
            {
                new Reservation{ReservationDate=DateTime.Parse("2020-02-21"), CourseID=1, StudentID=1},
                new Reservation{ReservationDate=DateTime.Parse("2020-02-22"), CourseID=2,StudentID=2},
                new Reservation{ReservationDate=DateTime.Parse("2020-02-23"), CourseID=3, StudentID=1}
            };
            reservations.ForEach(r => context.Reservations.Add(r));
            context.SaveChanges();
        }
    }
}