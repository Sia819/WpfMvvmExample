using GalaSoft.MvvmLight;
using MvvmExample.Model;
using System.Collections.ObjectModel;

namespace MvvmExample.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<MainMenu> _folderMenuCollection;
        public ObservableCollection<MainMenu> FolderMenuCollection
        { get => _folderMenuCollection ?? new ObservableCollection<MainMenu>(); }

        private MainMenu _selectedFolderMenuViewModel;
        public MainMenu SelectedFolderMenuViewModel
        {
            get => _selectedFolderMenuViewModel;
            set => Set(ref _selectedFolderMenuViewModel, value);
        }


        public MainWindowViewModel(Page1ViewModel page1ViewModel,
                                    Page2ViewModel page2ViewModel,
                                    Page3ViewModel page3ViewModel)
        {
            FolderMenuCollection.Add(new MainMenu() { Name = "Page1", TargetViewModel = page1ViewModel });
            FolderMenuCollection.Add(new MainMenu() { Name = "Page2", TargetViewModel = page2ViewModel });
            FolderMenuCollection.Add(new MainMenu() { Name = "Page3", TargetViewModel = page3ViewModel });
        }



    }
}
