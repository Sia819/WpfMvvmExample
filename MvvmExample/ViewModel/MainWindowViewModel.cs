using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MvvmExample.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MvvmExample.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<MainMenu> _folderMenuCollection;
        public ObservableCollection<MainMenu> FolderMenuCollection
        {
            //get => (_folderMenuCollection is not null) ? _folderMenuCollection : _folderMenuCollection = new ObservableCollection<MainMenu>();
            get
            {
                if (_folderMenuCollection == null)
                {
                    _folderMenuCollection = new ObservableCollection<MainMenu>();
                }
                return _folderMenuCollection;
            }
        }

        private MainMenu _selectedFolderMenuViewModel;
        public MainMenu SelectedFolderMenuViewModel
        {
            get => _selectedFolderMenuViewModel;
            set => Set(ref _selectedFolderMenuViewModel, value);
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
            var temp_Selected = new MainMenu() { Name = "Page1", TargetViewModel = page1ViewModel };
            //FolderMenuCollection.Add(new MainMenu() { Name = "Page1", TargetViewModel = page1ViewModel });
            FolderMenuCollection.Add(temp_Selected);
            FolderMenuCollection.Add(new MainMenu() { Name = "Page2", TargetViewModel = page2ViewModel });
            FolderMenuCollection.Add(new MainMenu() { Name = "Page3", TargetViewModel = page3ViewModel });
            //SelectedFolderMenuViewModel = FolderMenuCollection[0];
            SelectedFolderMenuViewModel = temp_Selected;
            IsFolderMenuOpen = false;
        }

        public ICommand MenuSwitch_Click { get => new RelayCommand(MenuSwitch_Click_Command); }
        private void MenuSwitch_Click_Command()
        {
            IsFolderMenuOpen = !IsFolderMenuOpen;
        }

    }
}
