using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApp.Models;
using RazorApp.Services;
using System.Collections.Generic;

namespace RazorApp.Pages
{
    public class TasksModel : PageModel
    {
        private readonly ITaskService _taskService;

        public List<TaskItem> Tasks { get; set; }

        public TasksModel(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public void OnGet()
        {
            Tasks = _taskService.GetAllTasks();
        }

        public IActionResult OnPostDelete(int id)
        {
            _taskService.DeleteTask(id);
            return RedirectToPage();
        }
    }
}
