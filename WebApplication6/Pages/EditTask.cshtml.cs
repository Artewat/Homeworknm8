using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApp.Models;
using RazorApp.Services;

namespace RazorApp.Pages
{
    public class EditTaskModel : PageModel
    {
        private readonly ITaskService _taskService;

        [BindProperty]
        public TaskItem Task { get; set; }

        public EditTaskModel(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public IActionResult OnGet(int id)
        {
            var task = _taskService.GetTaskById(id);
            if (task == null)
                return RedirectToPage("/Tasks");

            Task = task;
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _taskService.UpdateTask(Task);
            return RedirectToPage("/Tasks");
        }
    }
}
