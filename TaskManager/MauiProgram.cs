using Microsoft.Extensions.Logging;
using TaskManager.Services;
using TaskManager.Services.Contracts;
using TaskManager.ViewModels;

namespace TaskManager
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<ITaskService, TaskService>();

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<AddViewModel>();

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<AddTaskPage>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
