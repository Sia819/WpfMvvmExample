using CommunityTooklit_OnlySource_Basic.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace CommunityTooklit_OnlySource_Basic
{
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();

            _viewModel = new MainWindowViewModel();
            DataContext = _viewModel;

            // Bind controls to ViewModel properties
            BindingExpression bind1 = textBox1.SetBinding(TextBox.TextProperty, nameof(MainWindowViewModel.Text1));
            bind1.
            textBlock1.SetBinding(TextBlock.TextProperty, nameof(MainWindowViewModel.Text1));
            
            BindingExpression a = textBlock1.GetBindingExpression(TextBlock.TextProperty);
            a.UpdateSource();


            BindingExpressionBase base1 = textBox1.SetBinding(TextBox.TextProperty, new Binding(nameof(MainWindowViewModel.Text1))
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            });

            // Bind button click to command
            button1.Command = _viewModel.Func1Command;

            listBox1.SetBinding(ListBox.ItemsSourceProperty, nameof(MainWindowViewModel.Items));
        }
    }
}