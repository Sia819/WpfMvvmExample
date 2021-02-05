using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmExample.Model
{
    public class MainMenu
    {
        public Uri IconUri { get; set; }
        public string Name { get; set; }
        public ViewModelBase TargetViewModel { get; set; }
    }
}
