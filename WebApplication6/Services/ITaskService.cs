using System.Collections.Generic;
using RazorApp.Models;

namespace RazorApp.Services
{
    public interface ITaskService
    {
        List<TaskItem> GetAllTasks();
    }
}
