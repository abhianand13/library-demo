using System;
using System.Windows.Input;

namespace LibraryDemo.Helper
{
    public class DelegateCommand : ICommand
    {
        private Action action;
        private bool canExecute;

        public DelegateCommand(Action action, bool canExecute = true)
        {
            this.action = action;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
