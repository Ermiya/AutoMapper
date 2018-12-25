using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace AutoMapperSample.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual Address Address { get; set; }
        public Collection<Course> Courses { get; set; }
    }
    public static class MyStudent
    {
        public static List<Student> data = data = new List<Student>
            {
                new Student
                {
                    Id=1,
                    FirstName="hesam",
                    LastName="Akbari",
                    NationalCode="4980126081",
                    BirthDate=DateTime.Now,
                    Address=MyAddress.GetAddress,
                    Courses=Mycourse.GetCourses
                },
                new Student
                {
                    Id=2,
                    FirstName="Hamid",
                    LastName="Jafari",
                    NationalCode="4980126073",
                    BirthDate=DateTime.Now,
                    Address=MyAddress.GetAddress,
                    Courses=Mycourse.GetCourses
                },
                new Student
                {
                    Id=3,
                    FirstName="farshid",
                    LastName="saeidi",
                    NationalCode="2560126073",
                    BirthDate=DateTime.Now,
                    Address=MyAddress.GetAddress,
                    Courses=Mycourse.GetCourses
                }
            };
    
        
        public static IQueryable<Student> GetStudents()
        {
            return data.AsQueryable();

        }
    }
}