using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight;

namespace UI_Tutorial
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Type> _launchableWindowType;
        public ObservableCollection<Type> LaunchableWindowType { get => _launchableWindowType ??= new ObservableCollection<Type>(); }

        private int _list_SelectedIndex;
        public int List_SelectedIndex
        {
            get => _list_SelectedIndex;
            set => Set(ref _list_SelectedIndex, value);
        }

        private bool _isLaunch;
        public bool IsLaunch
        {
            get => _isLaunch;
            set => Set(ref _isLaunch, value);
        }


        public MainWindowViewModel()
        {
            IsLaunch = false;

            IEnumerable<TypeInfo> assems = Assembly.GetExecutingAssembly().DefinedTypes;
            var result = from q in assems where q.BaseType.Name == "Window" orderby q.Name select q;

            var resultArr = result.ToArray();
            for (int i = 0; i < resultArr.Length; i++)
            {
                if (resultArr[i].Name != "MainWindow")
                {
                    LaunchableWindowType.Add(resultArr[i]);
                }
            }
            List_SelectedIndex = 0;
        }

        private ICommand _launch_Command;
        public ICommand Launch_Command { get => _launch_Command ??= new RelayCommand(Launch_Window); }

        private void Launch_Window()
        {
            if (List_SelectedIndex >= 0)
            {
                var indexOfWindow = LaunchableWindowType[List_SelectedIndex];
                Window windowInstance = Activator.CreateInstance(indexOfWindow) as Window;
                IsLaunch = true;
                windowInstance.ShowDialog();
                IsLaunch = false;
            }
        }

    }
}
