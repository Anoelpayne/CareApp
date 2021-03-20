using CareApp.Data;
using CareApp.Models;
using CareApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace CareApp.Controllers
{
    public class TasksController : Controller
    {
        private CareAppDbContext context;
        public TasksController(CareAppDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<ATask> tasks = context.Tasks.ToList();
            return View(tasks);
        }

        public IActionResult AddTask()
        {
            AddTaskViewModel addTaskViewModel = new AddTaskViewModel();
            return View(addTaskViewModel);
        }

        [HttpPost]
        public IActionResult AddTask(AddTaskViewModel addTaskViewModel)
        {
            if (ModelState.IsValid)
            {
                ATask newTask = new ATask
                {
                    Name = addTaskViewModel.Name,
                    Id = addTaskViewModel.TaskId
                };

                context.Tasks.Add(newTask);
                context.SaveChanges();

                return Redirect("/Tasks");
            }

            return View(addTaskViewModel);
        }
    }
}
