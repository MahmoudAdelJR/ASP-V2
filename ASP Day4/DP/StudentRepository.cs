using ASP_Day4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Day4.DB
{
    public class StudentRepository : IStudentRepository
    {
        IStudentContext context;
        public StudentRepository(IStudentContext ctx)
        {
            context = ctx;
        }
        public void Add(Student student)
        {
            context.students.Add(student);
        }

        public List<Student> GetAll()
        {
            return context.students;
        }

        public Student GetByNid(string Nid)
        {
            return context.students.Where(s => s.nid == Nid).FirstOrDefault();
        }

        public void RemoveByNid(string Nid)
        {
            context.students.Remove(context.students.Where(s => s.nid == Nid).FirstOrDefault());
        }
    }
}