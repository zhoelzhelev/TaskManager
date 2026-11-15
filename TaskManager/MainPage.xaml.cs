using TaskManager.ViewModels;

namespace TaskManager
{
    public partial class MainPage : ContentPage
    {
  

        public MainPage(MainViewModel mv)
        {
            InitializeComponent();
            BindingContext = mv;
        }

       
    }
}
