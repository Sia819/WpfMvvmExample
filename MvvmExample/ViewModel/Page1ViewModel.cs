namespace MvvmExample.ViewModel
{
    using GalaSoft.MvvmLight;

    public class Page1ViewModel : ViewModelBase
    {
        private string _text;
        public string Text
        {
            get => _text;
            set => Set(ref _text, value);
        }

        public Page1ViewModel()
        {
            Text = "Page1 Binding";
        }
    }
}
