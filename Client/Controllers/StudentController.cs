using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddData(Student model)
        {
            using (var context = new demoCRUDEntities())
            {
                context.Students.Add(model);
                context.SaveChanges();
            }
            string message = "Add the record successfully";
            ViewBag.Message = message;

            return View();
        }

        [HttpGet] // Set the attribute to Read 
        public ActionResult GetData()
        {
            using (var context = new demoCRUDEntities())
            {
                var data = context.Students.ToList();
                return View(data);
            }
        }
    }
}
}