using MvvmExample.ViewModel;
using GalaSoft.MvvmLight.Ioc;


namespace MvvmExample.Common
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainWindowViewModel>();

        }

        public MainWindowViewModel MainWindowDataContext { get => SimpleIoc.Default.GetInstance<MainWindowViewModel>(); }
    }
}
