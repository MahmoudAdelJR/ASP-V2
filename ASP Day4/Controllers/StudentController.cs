using ASP_Day4.DB;
using ASP_Day4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_Day4.Controllers
{
    public class StudentController : Controller
    {
        IStudentRepository repo;
        public StudentController(IStudentRepository _repo)
        {
            repo = _repo;
        }
        // GET: Student
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(Student student)
        {
            repo.Add(student);
            return Redirect("Index");
        }
        public ActionResult delete(string nid)
        {
            repo.RemoveByNid(nid);
            return Redirect("Index");
        }
        [HttpGet]
        public ActionResult update(string nid)
        {
            TempData["nid"] = nid;
            return View(repo.GetByNid(nid));
        }
        [HttpPost]
        public ActionResult update(Student student)
        {
            Student st= repo.GetByNid(TempData.Peek("nid").ToString());
            st.name = student.name;
            st.age = student.age;
            st.nid = student.nid;
            st.grade = student.grade;
            return Redirect("Index");
        }
    }
}