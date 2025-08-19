using System.Collections.Generic;
using System.Linq;
using RazorApp.Models;

namespace RazorApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly List<TaskItem> _tasks;
        private int _nextId = 1;

        public TaskService()
        {
            _tasks = new List<TaskItem>
            {
                new TaskItem { Id = 1, Title = "Сделать домашку", Description = "ASP.NET Core Razor Pages" },
                new TaskItem { Id = 2, Title = "Прочитать книгу", Description = "Читаем главы 1-3" },
                new TaskItem { Id = 3, Title = "Купить продукты", Description = "Молоко, хлеб, сыр" }
            };
            _nextId = _tasks.Max(t => t.Id) + 1;
        }

        public List<TaskItem> GetAllTasks() => _tasks;

        public TaskItem? GetTaskById(int id) => _tasks.FirstOrDefault(t => t.Id == id);

        public void AddTask(TaskItem task)
        {
            task.Id = _nextId++;
            _tasks.Add(task);
        }

        public void UpdateTask(TaskItem task)
        {
            var existing = GetTaskById(task.Id);
            if (existing != null)
            {
                existing.Title = task.Title;
                existing.Description = task.Description;
            }
        }

        public void DeleteTask(int id)
        {
            var task = GetTaskById(id);
            if (task != null)
                _tasks.Remove(task);
        }
    }
}
