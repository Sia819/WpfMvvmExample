using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace JustBindingTest.ViewModel
{
    /// Binding을 처음할때는 Notify 개념을 이해하기 힘듦으로, 확장 프레임워크를 사용하시면 쉽게 구현할 수 있습니다.
    public class MainWindowViewModel : ViewModelBase 
    {
        /// 바인딩이 View에서는 정상적으로 Text 프로퍼티에는 전달이 되지만,
        /// INotifyPropertyChange event가 없기 때문에 ViewModel에서 Text가 수정되면
        /// 내용이 View로 전달되지 않습니다.
        private string _text1;
        public string Text1
        {
            get { return _text1; }
            set { _text1 = value; }
        }

        private string _text2;
        public string Text2
        {
            get { return _text2; }
            set { Set(ref _text2, value); }     /// Set함수는 MvvmLight에서 제공하는 프로퍼티 변경 알림 함수입니다.
        }

        /// View에서 Command 바인딩을 할 경우 이 프로퍼티로 바인딩을 하여, 코드를 실행할 수 있습니다.
        public ICommand Test1_Button_Click { get; set; }
        public ICommand Test2_Button_Click { get; set; }

        public MainWindowViewModel()
        {
            // Command Binding Init
            /// ICommand 프로퍼티에 MvvmLight에서 제공한 함수를 이용하여 커맨드가 수행할 작업을 등록해줍니다.
            Test1_Button_Click = new RelayCommand(Test1_Button_Click_Command);
            Test2_Button_Click = new RelayCommand(Test2_Button_Click_Command);
        }

        private void Test1_Button_Click_Command()
        {
            // Command Binding to some working
            Text1 = Text1 + "(Changed in VM)";
            MessageBox.Show(Text1);
        }
        private void Test2_Button_Click_Command()
        {
            // Command Binding to some working
            Text2 = Text2 + "(Changed in VM)";
            MessageBox.Show(Text2);
        }
    }
}
