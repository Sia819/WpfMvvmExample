using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MenuPresenter.UC
{
    public class MenuPanelViewModel : ViewModelBase
    {
        private bool _isFolderMenuOpen;
        public bool IsFolderMenuOpen
        {
            get => _isFolderMenuOpen;
            set => Set(ref _isFolderMenuOpen, value);
        }

        private ObservableCollection<Model.MenuItem> _folderMenuCollection;
        public ObservableCollection<Model.MenuItem> FolderMenuCollection
        {
            get => (_folderMenuCollection is not null) ? _folderMenuCollection : _folderMenuCollection = new ObservableCollection<Model.MenuItem>();
        }

        private Model.MenuItem _folderMenuSelectedViewModel;
        public Model.MenuItem FolderMenuSelectedViewModel
        {
            get => _folderMenuSelectedViewModel;
            set => Set(ref _folderMenuSelectedViewModel, value);
        }

        #region Command

        public ICommand MenuSwitch_Click { get => new RelayCommand(MenuSwitch_Click_Command); }
        private void MenuSwitch_Click_Command()
        {
            IsFolderMenuOpen = !IsFolderMenuOpen;
        }

        #endregion

        public MenuPanelViewModel()
        {
            IsFolderMenuOpen = false;
        }
    }
}
