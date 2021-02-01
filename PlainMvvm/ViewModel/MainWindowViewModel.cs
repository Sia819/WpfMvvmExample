using PlainMvvm.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace PlainMvvm.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string info) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));

        private string _myValue;
        public string MyValue
        {
            get => _myValue;
            set { _myValue = value; OnPropertyChanged(nameof(_myValue)); }
        }

        private string _inputBox;
        public string InputBox
        {
            get => _inputBox;
            set { _inputBox = value; OnPropertyChanged(nameof(_inputBox)); }
        }


        public ICommand SetValue_Button_Click { get; set; }

        public MainWindowViewModel()
        {
            SetValue_Button_Click = new RelayCommand(SetValue_Button_Click_Command);
        }

        private void SetValue_Button_Click_Command()
        {
            
        }



    }
}
