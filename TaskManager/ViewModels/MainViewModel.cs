using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TaskManager.Models;
using TaskManager.Services.Contracts;

namespace TaskManager.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<TaskItem> Tasks { get; }

        public MainViewModel(ITaskService taskService)
        {
            Tasks = taskService.Tasks;
        }

        [RelayCommand]
        async Task Tap() => await Shell.Current.GoToAsync(nameof(AddTaskPage));
    }
}
