using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;

namespace UI_Tutorial.Chrome
{
    public class ChromeViewModel : ViewModelBase
    {
        #region Private Member

        private Window _window;
        // 윈도우 테두리 보더
        private int _outerMarginSize = 1;
        // 타이틀바 높이
        private int _titleHeight = 30;
        // 윈도우 둥글기
        private int _windowRadius = 0;
        private ICommand _minimizeCommand;
        private ICommand _maximizeCommand;
        private ICommand _closeCommand;
        private ICommand _menuCommand;

        #endregion

        #region Public Properties

        public double WindowMinimumWidth { get; set; } = 136;

        public double WindowMinimumHeight { get; set; } = 39;

        public WindowState WindowWindowState { get; set; }

        public int ResizeBorder { get; set; } = 10; // 왜 굳이 프로퍼티로 남아야되는지 동영상에서 재확인

        // can drag to resize border area
        public Thickness ResizeBorderThickness { get => new Thickness(ResizeBorder + OuterMarginSize,
                                                                        OuterMarginSize,
                                                                        ResizeBorder + OuterMarginSize,
                                                                        ResizeBorder + OuterMarginSize); }

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

        public int TitleHeight
        {
            get => _titleHeight;
            set => Set(ref _titleHeight, value);
        }

        public GridLength TitleHeightGridLength { get => new GridLength(TitleHeight); }



        #endregion

        #region Command

        /// <summary>
        /// The command to minimize the window.
        /// </summary>
        public ICommand MinimizeCommand
        {
            get => _minimizeCommand ??= new RelayCommand<Window>((obj) => MinimizeFunc(_window));
            set => _minimizeCommand = value;
        }
        /// <summary>
        /// The command to maximize the window.
        /// </summary>
        public ICommand MaximizeCommand
        {
            get => _maximizeCommand ??= new RelayCommand<Window>((obj) => MaximizeFunc(_window));
            set => _maximizeCommand = value;
        }
        /// <summary>
        /// The command to close the window.
        /// </summary>
        public ICommand CloseCommand
        {
            get => _closeCommand ??= new RelayCommand<Window>((obj) => CloseFunc(_window));
            set => _closeCommand = value;
        }
        /// <summary>
        /// The command to show the window system menu.
        /// </summary>
        public ICommand MenuCommand
        {
            get => _menuCommand ??= new RelayCommand<Window>((obj) => MenuFunc(_window));
            set => _menuCommand = value;
        }

        #endregion

        #region Private Function

        private void MinimizeFunc(Window window) => window.WindowState = WindowState.Minimized;
        private void MaximizeFunc(Window window) => window.WindowState ^= WindowState.Maximized;
        private void CloseFunc(Window window) => window.Close();
        private void MenuFunc(Window window) => SystemCommands.ShowSystemMenu(window, window.PointToScreen(GetMousePosition(window)));

        #endregion

        #region Constructor

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

        #endregion

        #region Public Function

        /// <summary>
        /// Gets the current mouse position on the screen
        /// </summary>
        /// <returns></returns>
        private Point GetMousePosition(Window window)
        {
            var position = Mouse.GetPosition(window);
            return new Point(position.X, position.Y);
        }

        #endregion
    }
}
