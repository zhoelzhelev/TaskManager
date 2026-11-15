using TaskManager.ViewModels;

namespace TaskManager;

public partial class AddTaskPage : ContentPage
{
	public AddTaskPage(AddViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}