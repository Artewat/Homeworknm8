using System;

namespace RazorApp.Models
{
    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
