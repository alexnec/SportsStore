using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class CoursesController : Controller
    {
        //
        // GET: /Courses/
        public ActionResult Index()
        {
            ViewBag.Hello = "hi";
            return View();
        }

        public ActionResult FileUpload()
        {
            return View();
        }
	}
}