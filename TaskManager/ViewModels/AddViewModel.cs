using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Models;
using TaskManager.Services.Contracts;

namespace TaskManager.ViewModels
{
    public partial class AddViewModel : ObservableObject
    {
        private readonly ITaskService _taskService;

        public AddViewModel(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [ObservableProperty]
        private string? name;

        [ObservableProperty]
        private string? activity;

        [ObservableProperty]
        private string? time;

        [ObservableProperty]
        private string? imageURL;

        [RelayCommand]
        async Task Add()
        {
            if (String.IsNullOrWhiteSpace(name) ||
                String.IsNullOrWhiteSpace(activity) ||
                String.IsNullOrWhiteSpace(time) ||
                String.IsNullOrWhiteSpace(imageURL)) return;

            TaskItem task = new TaskItem()
            {
                Name = name,
                Acctivity = activity,
                Time = time,
                ImageURL = imageURL
            };

            _taskService.Add(task);

            await Shell.Current.GoToAsync("..");
        }
    }
}
