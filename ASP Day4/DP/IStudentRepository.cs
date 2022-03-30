using ASP_Day4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Day4.DB
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student GetByNid(string Nid);
        void Add(Student student);
        void RemoveByNid(string Nid);
    }
}