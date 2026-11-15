using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TaskManager.Models;
using TaskManager.Services.Contracts;

namespace TaskManager.Services
{
    public class TaskService : ITaskService
    {
        public ObservableCollection<TaskItem> Tasks { get; } = new();

        public void Add(TaskItem task) => Tasks.Add(task);
        
    }
}
