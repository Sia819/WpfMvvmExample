using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CommunityTooklit_OnlySource_Basic.ViewModel
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty] private string text1;
        [ObservableProperty] private ObservableCollection<string> items;

        public MainWindowViewModel()
        {
            text1 = "Hello Binding!";
            items = new ObservableCollection<string>();
            items.Add("1");
            items.Add("2");
            items.Add("3");
        }

        [RelayCommand]
        private void Func1()
        {
            Debug.WriteLine("Func1 excuted!");
        }
    }
}
