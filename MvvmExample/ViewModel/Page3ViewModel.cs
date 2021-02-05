namespace MvvmExample.ViewModel
{
    using GalaSoft.MvvmLight;

    public class Page3ViewModel : ViewModelBase
    {
        private string _text;
        public string Text
        {
            get => _text;
            set => Set(ref _text, value);
        }

        public Page3ViewModel()
        {
            Text = "Page3 Binding";
        }
    }
}
