using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Mvvmlight.BindingTest.ViewModel
{
    public class MainWindowViewModel
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        /// Any testing command 
        /// </summary>
        public ICommand Test_Button { get; set; }

        public MainWindowViewModel()
        {
            // Command Binding Init
            Test_Button = new RelayCommand(Test_Button_Command);
        }

        private void Test_Button_Command()
        {
            // Command Binding to some working
            MessageBox.Show("Hello, Command Binding!");
        }
    }
}
