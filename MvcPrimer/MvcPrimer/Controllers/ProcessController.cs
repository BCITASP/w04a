using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace MvcPrimer.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        public ActionResult Index()
        {
            ViewBag.MyMessage = "This is my process index action method";
            return View();
        }

        public ActionResult List()
        {
            //var processes = (Process.GetProcesses()
            //    .OrderBy(p => p.ProcessName)
            //    .Select(p => p)).ToList();

            var processes = (from p in Process.GetProcesses()
                            orderby p.ProcessName
                            select p).ToList();

            //ViewBag.SystemProcesses = processes;

            return View(processes);
        }

        public ActionResult Details(int id)
        {
            Process process = (from p in Process.GetProcesses()
                            where p.Id == id
                             select p).FirstOrDefault();
            return View(process);
        }
    }
}