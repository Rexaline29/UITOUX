using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace MVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            IEnumerable<MVCStudentModel> studList;
            HttpResponseMessage response = GlobalVariables.webapiclient.GetAsync("Student").Result;
            studList = response.Content.ReadAsAsync<IEnumerable<MVCStudentModel>>().Result;

            return View(studList);
        }

        public ActionResult AddOrEdit(int id=0)
        {
            return View(new MVCStudentModel());
        }
        [HttpPost]
        public ActionResult AddOrEdit()
        {
            return View();
        }
    }
}