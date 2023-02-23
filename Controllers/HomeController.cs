using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission8_covey.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission8_covey.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // context file for Task Context
        private TaskContext taskContext { get; set; }
        // home controller func with task context added
        public HomeController(ILogger<HomeController> logger, TaskContext x)
        {
            _logger = logger;
            taskContext = x;
        }
       
        
        // quandrants view
        public IActionResult Quandrants()
        {
            var tasks = taskContext.Responses
                .OrderBy(x => x.Task)
                .Where(x => x.completed == false)
                .ToList();
            return View();
        }

        // tasks get view -- for adding new tasks 
        [HttpGet]
        public IActionResult Tasks()
        {
            ViewBag.Category = taskContext.Categories.ToList();
            return View();
        }

        // tasks post view -- for adding new tasks 
        [HttpPost]
        public IActionResult Tasks(TaskResponse tr)
        {
            if (ModelState.IsValid)
            {
                taskContext.Add(tr);
                taskContext.SaveChanges();

                return View(tr);
            }
            else
            {
                //ViewBag.Category = taskContext.Category.ToList();
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int taskId)
        {
            //ViewBag.Categories = taskContext.Category.ToList();

            var taskResponse = taskContext.Responses.Single(x => x.TaskId == taskId);

            return View("Quandrants", taskResponse);
        }

        [HttpPost]
        public IActionResult Edit(TaskResponse mfr)
        {
            taskContext.Update(mfr);
            taskContext.SaveChanges();
            return RedirectToAction("Quandrants");
        }

        [HttpGet]
        public IActionResult Delete(int taskId)
        {
            var taskResponse = taskContext.Responses.Single(x => x.TaskId == taskId);

            return View(taskResponse);
        }

        [HttpPost]
        public IActionResult Delete(TaskResponse mfr)
        {
            taskContext.Responses.Remove(mfr);
            taskContext.SaveChanges();

            return RedirectToAction("Quandrants");
        }

    }
}
