using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Web.Hosting;

namespace MvcPrimer.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            string[] filenames = Directory.GetFiles(HostingEnvironment.MapPath("~/textfiles"));
            return View(filenames);
        }

        public ActionResult ShowContent(string path)
        {
            if (path == null) { return View(); }
            ViewBag.Content = System.IO.File.ReadAllText(path);
            return View();
        }
    }
}