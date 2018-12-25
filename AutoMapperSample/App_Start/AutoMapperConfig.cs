using AutoMapperSample.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperSample.App_Start
{
    public class AutoMapperConfig
    {
        public static void Registration()
        {
            AutoMapper.Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile>());
        }
    }
}