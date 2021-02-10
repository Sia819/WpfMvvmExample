namespace MvvmExample.ViewModel
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    public class Page2ViewModel : ViewModelBase
    {

        private string _ex1ListNewItem;
        public string Ex1ListNewItem { get => _ex1ListNewItem; set => Set(ref _ex1ListNewItem, value); }

        private int _ex1ListSelectedIndex;
        public int Ex1ListSelectedIndex { get => _ex1ListSelectedIndex; set => Set(ref _ex1ListSelectedIndex, value); }

        public ObservableCollection<string> Ex1ListCollection { get; set; }

        public Page2ViewModel()
        {
            Ex1ListCollection = new ObservableCollection<string>();
            Ex1ListCollection.Add("dumi data 1");
            Ex1ListCollection.Add("dumi data 2");
            Ex1ListCollection.Add("dumi data 3");
        }

        private ICommand _ex1ListAdd_Command;
        public ICommand Ex1ListAdd_Command { get => _ex1ListAdd_Command ??= new RelayCommand(Ex1ListAdd); }
        private void Ex1ListAdd()
        {
            Ex1ListCollection.Add(Ex1ListNewItem);
        }

        private ICommand _ex1ListRemove_Command;
        public ICommand Ex1ListRemove_Command { get => _ex1ListRemove_Command ??= new RelayCommand(Ex1ListRemove); }
        private void Ex1ListRemove()
        {
            Ex1ListCollection.RemoveAt(Ex1ListSelectedIndex);
        }

        private ICommand _ex1ListMoveUp_Command;
        public ICommand Ex1ListMoveUp_Command { get => _ex1ListMoveUp_Command ??= new RelayCommand(Ex1ListMoveUp); }
        private void Ex1ListMoveUp()
        {
            if (Ex1ListSelectedIndex > 0)
                Ex1ListCollection.Move(Ex1ListSelectedIndex, Ex1ListSelectedIndex - 1);
            else
                return;
        }

        private ICommand _ex1ListMoveDown_Command;
        public ICommand Ex1ListMoveDown_Command { get => _ex1ListMoveDown_Command ??= new RelayCommand(Ex1ListMoveDown); }
        private void Ex1ListMoveDown()
        {
            if (Ex1ListSelectedIndex < Ex1ListCollection.Count - 1)
                Ex1ListCollection.Move(Ex1ListSelectedIndex, Ex1ListSelectedIndex + 1);
            else
                return;
        }
    }
}
