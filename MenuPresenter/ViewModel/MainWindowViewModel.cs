using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPresenter.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {

        public ObservableCollection<string> MyCollection1 { get; set; }

        public MainWindowViewModel()
        {
            MyCollection1 = new ObservableCollection<string>();
            MyCollection1.Add("a");
            MyCollection1.Add("b");
            MyCollection1.Add("c");
        }
    }
}
