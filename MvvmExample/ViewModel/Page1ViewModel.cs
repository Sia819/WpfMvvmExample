namespace MvvmExample.ViewModel
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using System.Windows;
    using System.Windows.Input;

    public class Page1ViewModel : ViewModelBase
    {
        private string _textBinding_Text;
        public string TextBinding_Text
        {
            get => _textBinding_Text;
            set => Set(ref _textBinding_Text, value);
        }

        private string _commandBinding_Text;
        public string CommandBinding_Text
        {
            get => _commandBinding_Text;
            set => Set(ref _commandBinding_Text, value);
        }

        public Page1ViewModel()
        {
            TextBinding_Text = "Type to change this Text!";
            CommandBinding_Text = "Type to change and click button!";
        }

        public ICommand BtnCmd_Click { get => new RelayCommand(BtnCmd_Click_Command); }
        private void BtnCmd_Click_Command()
        {
            MessageBox.Show(CommandBinding_Text);
        }

    }
}
