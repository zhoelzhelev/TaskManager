using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TaskManager.Models;

namespace TaskManager.Services.Contracts
{
    public interface ITaskService
    {
        ObservableCollection<TaskItem> Tasks { get; }

        void Add(TaskItem task);
    }
}
