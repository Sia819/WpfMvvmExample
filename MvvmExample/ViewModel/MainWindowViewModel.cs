using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmExample.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;

namespace MvvmExample.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<MainMenu> _folderMenuCollection;
        public ObservableCollection<MainMenu> FolderMenuCollection
        {
            get => (_folderMenuCollection is not null) ? _folderMenuCollection : _folderMenuCollection = new ObservableCollection<MainMenu>();
        }

        private MainMenu _folderMenuSelectedViewModel;
        public MainMenu FolderMenuSelectedViewModel
        {
            get => _folderMenuSelectedViewModel;
            set => Set(ref _folderMenuSelectedViewModel, value);
        }

        private bool _isFolderMenuOpen;
        public bool IsFolderMenuOpen
        {
            get => _isFolderMenuOpen;
            set => Set(ref _isFolderMenuOpen, value);
        }

        public MainWindowViewModel(Page1ViewModel page1ViewModel,
                                    Page2ViewModel page2ViewModel,
                                    Page3ViewModel page3ViewModel)
        {
            FolderMenuCollection.Add(new MainMenu() { IconUri = new Uri("pack://application:,,,/Image/page_26px_black.png", UriKind.RelativeOrAbsolute), 
                                                        Name = "Page1", TargetViewModel = page1ViewModel });
            FolderMenuCollection.Add(new MainMenu() { IconUri = new Uri("pack://application:,,,/Image/page_26px_black.png", UriKind.RelativeOrAbsolute), 
                                                        Name = "Page2", TargetViewModel = page2ViewModel });
            FolderMenuCollection.Add(new MainMenu() { IconUri = new Uri("pack://application:,,,/Image/page_26px_black.png", UriKind.RelativeOrAbsolute), 
                                                        Name = "Page3", TargetViewModel = page3ViewModel });
            FolderMenuSelectedViewModel = FolderMenuCollection[0];
            IsFolderMenuOpen = false;
        }

        public ICommand MenuSwitch_Click { get => new RelayCommand(MenuSwitch_Click_Command); }
        private void MenuSwitch_Click_Command()
        {
            IsFolderMenuOpen = !IsFolderMenuOpen;
        }

    }
}
