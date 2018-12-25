using AutoMapperSample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperSample.Models
{
    public class StudentViewModel
    {
        public int SteudentId { get; set; }
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public string Address { get; set; }
        public List<Course> CoursList{ get; set; }

    }
}