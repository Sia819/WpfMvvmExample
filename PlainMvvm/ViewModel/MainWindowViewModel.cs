using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PlainMvvm.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));

        public MainWindowViewModel()
        {

        }

        
    }
}
