using System;
using System.Windows.Input;

namespace Expense_Tracker.Core
{
    /**
     *  This class is used to relay commands from the UI to the ViewModel.
     */
    internal class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested += value;
                }
            }
            remove
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            if (execute == null)
            {
                throw new ArgumentNullException(nameof(execute));
            }
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter = null)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter = null)
        {
            _execute(parameter);
        }
    }
}
