namespace MvvmExample.Common
{
    using GalaSoft.MvvmLight.Ioc;

    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<ViewModel.MainWindowViewModel>();
            SimpleIoc.Default.Register<ViewModel.Page1ViewModel>();
            SimpleIoc.Default.Register<ViewModel.Page2ViewModel>();
            SimpleIoc.Default.Register<ViewModel.Page3ViewModel>();
        }

        public ViewModel.MainWindowViewModel MainWindowViewModel
        { get => SimpleIoc.Default.GetInstance<ViewModel.MainWindowViewModel>(); }
    }
}

