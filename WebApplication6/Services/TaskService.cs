using System.Collections.Generic;
using RazorApp.Models;

namespace RazorApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly List<TaskItem> _tasks;

        public TaskService()
        {
            _tasks = new List<TaskItem>
            {
                new TaskItem { Title = "Сделать домашку", Description = "ASP.NET Core Razor Pages" },
                new TaskItem { Title = "Прочитать книгу", Description = "Читаем главы 1-3" },
                new TaskItem { Title = "Купить продукты", Description = "Молоко, хлеб, сыр" }
            };
        }

        public List<TaskItem> GetAllTasks() => _tasks;
    }
}
