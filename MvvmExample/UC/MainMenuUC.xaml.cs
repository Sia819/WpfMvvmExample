using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MvvmExample.UC
{
    /// <summary>
    /// MainMenuUserControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainMenuUC : UserControl
    {
        public MainMenuUC()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty IsOpenProperty = DependencyProperty.Register("IsOpen", typeof(bool), typeof(MainMenuUC));
        public bool IsOpen
        {
            get => (bool)GetValue(IsOpenProperty);
            set => SetValue(IsOpenProperty, value);
        }

        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource", typeof(ObservableCollection<Model.MainMenu>), typeof(MainMenuUC));
        public ObservableCollection<Model.MainMenu> ItemsSource
        {
            get => (ObservableCollection<Model.MainMenu>)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public static readonly DependencyProperty SelectedItemProperty = DependencyProperty.Register("SelectedItem", typeof(Model.MainMenu), typeof(MainMenuUC));
        public Model.MainMenu SelectedItem
        {
            get => (Model.MainMenu)GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

    }
}
