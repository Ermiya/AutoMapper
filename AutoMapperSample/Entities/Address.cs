using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapperSample.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string PostalCode { get; set; }
        public ICollection<Student> Students { get; set; }
    }
    public static class MyAddress
    {
        public static Address GetAddress
        {
            get
            {
                var data = new Address
                {
                    Id = 1,
                    Description = "Mazandran , simorgh",
                    PostalCode = "4773113111"
                };
                return data;
            }

        }
    }
}