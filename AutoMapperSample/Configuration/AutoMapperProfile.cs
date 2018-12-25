using AutoMapper;
using AutoMapperSample.Entities;
using AutoMapperSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperSample.Configuration
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentViewModel>()
                //If necessary
                .ForMember(f => f.FullName, w => w.MapFrom(a => string.Format("{0} {1}", a.FirstName, a.LastName)))
                .ForMember(f=>f.Address,w=>w.MapFrom(a=>a.Address.Description))
                .ForMember(f => f.CoursList, w => w.MapFrom(a => a.Courses));
        }
    }
}