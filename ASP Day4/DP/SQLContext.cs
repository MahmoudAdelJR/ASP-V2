using ASP_Day4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Day4.DB
{
    public class SQLContext : IStudentContext
    {
        public List<Student> students { get; set; }
        public SQLContext()
        {
            students = new List<Student>()
            {
                new Student(){name="Mahmoud",age=25,nid="12345678",grade=9}
            };
        }
    }
}