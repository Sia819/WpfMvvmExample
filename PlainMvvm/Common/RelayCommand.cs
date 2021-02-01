namespace PlainMvvm.Common
{
    using System;
    using System.Windows.Input;

    /// RelayCommand를 사용하면 View로부터 Command Binding을 사용할 수 있습니다.
    /// 주로 사용되는 부분은, MVVM패턴을 사용할 때 ViewModel쪽에서 Function을 View의 Command로 바인딩하기(연결시키기)위해 주로 사용됩니다.
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        private Action methodToExecute;
        private Func<bool> canExecuteEvaluator;

        public RelayCommand(Action methodToExecute, Func<bool> canExecuteEvaluator)
        {
            this.methodToExecute = methodToExecute;
            this.canExecuteEvaluator = canExecuteEvaluator;
        }
        public RelayCommand(Action methodToExecute) : this(methodToExecute, null) { }

        public bool CanExecute(object parameter)
            => this.canExecuteEvaluator is null ? true : this.canExecuteEvaluator.Invoke();

        public void Execute(object parameter)
            => this.methodToExecute.Invoke();
    }
}
