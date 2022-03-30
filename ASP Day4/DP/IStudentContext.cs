using ASP_Day4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Day4.DB
{
    public interface IStudentContext
    {
        List<Student> students {get;set;}
    }
}