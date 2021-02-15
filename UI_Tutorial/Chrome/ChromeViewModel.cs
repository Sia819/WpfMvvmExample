using GalaSoft.MvvmLight;
using System.Windows;

namespace UI_Tutorial.Chrome
{
    public class ChromeViewModel : ViewModelBase
    {
        #region Private Member

        private Window _window;
        private int _outerMarginSize = 10;
        private int _windowRadius = 10;

        #endregion

        #region Public Properties

        public int ResizeBorder { get; set; } = 6;
        public Thickness ResizeBorderThickness { get => new Thickness(ResizeBorder + OuterMarginSize); }
        public int OuterMarginSize
        {
            get => (_window.WindowState == WindowState.Maximized) ? 0 : _outerMarginSize;
            set => Set(ref _outerMarginSize, value);
        }
        public Thickness OuterMarginSizeThickness { get => new Thickness(OuterMarginSize); }
        public int WindowRadius
        {
            get => (_window.WindowState == WindowState.Maximized) ? 0 : _windowRadius;
            set => Set(ref _windowRadius, value);
        }
        public CornerRadius WindowCornerRadius { get => new CornerRadius(WindowRadius); }
        public int TitleHeight { get; set; } = 42;
        public GridLength TitleHeightGridLength { get => new GridLength(TitleHeight); }


        #endregion




        public ChromeViewModel(Window window)
        {
            _window = window;
            _window.StateChanged += (sender, e) =>
            {
                RaisePropertyChanged(nameof(ResizeBorderThickness));
                RaisePropertyChanged(nameof(OuterMarginSize));
                RaisePropertyChanged(nameof(OuterMarginSizeThickness));
                RaisePropertyChanged(nameof(WindowRadius));
                RaisePropertyChanged(nameof(WindowCornerRadius));
            };
        }
    }
}
