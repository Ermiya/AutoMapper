using AutoMapperSample.Entities;
using AutoMapperSample.Models;
using System;
using System.Collections.Generic;
using AutoMapper.QueryableExtensions;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoMapperSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = MyStudent.GetStudents();
            //Solution 1
            var result1 = AutoMapper.Mapper.Map<List<StudentViewModel>>(data);
            //solution 2
            var result2 = data.ProjectTo<StudentViewModel>().ToList();

            //ff

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}