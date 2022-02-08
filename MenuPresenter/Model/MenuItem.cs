using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPresenter.Model
{
    public class MenuItem
    {
        public Uri IconUri { get; set; }
        public string Name { get; set; }
        public ViewModelBase TargetViewModel { get; set; }
    }
}
