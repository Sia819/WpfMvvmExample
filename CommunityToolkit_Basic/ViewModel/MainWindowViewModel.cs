using CommunityToolkit.Mvvm.ComponentModel;

namespace CommunityToolkit_Basic.ViewModel
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string text;

        public MainWindowViewModel()
        {
            text = "Hello Binding!";
        }
    }
}
