using Framework_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Framework_WebApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public static IList<Student> studentList = new List<Student>{
                new Student() { id = 1, name = "John", Age = 18 } ,
                new Student() { id = 2, name = "Steve",  Age = 21 } ,
                new Student() { id = 3, name = "Bill",  Age = 25 } ,
                new Student() { id = 4, name = "Ram" , Age = 20 } ,
                new Student() { id = 5, name = "Ron" , Age = 31 } ,
                new Student() { id = 4, name = "Chris" , Age = 17 } ,
                new Student() { id = 4, name = "Rob" , Age = 19 } };

        public ActionResult Index()
        {
            return View(studentList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student std)
        {
            studentList.Add(std);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var std = studentList.Where(x => x.id == id).FirstOrDefault();
            return View(std);
        }

        public string Delete()
        {
            return "This is Delete action method of StudentController";
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            //update student in DB using EntityFramework in real-life application

            //update list by removing old student and adding updated student for demo purpose

            if (ModelState.IsValid)
            {
                var student = studentList.Where(s => s.id == std.id).FirstOrDefault();
                studentList.Remove(student);
                studentList.Add(std);

                return RedirectToAction("Index");
            }
            return View(std);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            // delete student from the database whose id matches with specified id

            return RedirectToAction("Delete");
        }


    }
}