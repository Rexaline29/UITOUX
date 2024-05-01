using MVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MVC.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        [HttpGet]
        public ActionResult Index()
        {
            //C:\Dot Net Applications\WebApiWithMVC\MVC\Images
            //string path = @"~/Images/UITOUX_Task.pdf";
            //return File(path, "application/pdf", "UITOUX_Task.pdf"); 
            return View();
        }
    }
}