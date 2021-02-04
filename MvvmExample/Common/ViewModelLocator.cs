using MvvmExample.ViewModel;
using GalaSoft.MvvmLight.Ioc;


namespace MvvmExample.Common
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainWindowViewModel>();
            SimpleIoc.Default.Register<Page1ViewModel>();
            SimpleIoc.Default.Register<Page2ViewModel>();
            SimpleIoc.Default.Register<Page3ViewModel>();
        }

        public MainWindowViewModel MainWindowDataContext { get => SimpleIoc.Default.GetInstance<MainWindowViewModel>(); }
    }
}

