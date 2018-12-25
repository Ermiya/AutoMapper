using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace AutoMapperSample.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public Collection<Student>  Students{ get; set; }
    }
    public static class Mycourse
    {
        public static Collection<Course> GetCourses
        {
            get
            {
                var data = new Collection<Course>
                {
                    new Course
                    {
                        Id=1,
                        Title ="C#.NET",
                        Description="Welcome To C# Course",
                        CreationDate=DateTime.Now
                    }
               };
                return data;
            }

        }
    }
}