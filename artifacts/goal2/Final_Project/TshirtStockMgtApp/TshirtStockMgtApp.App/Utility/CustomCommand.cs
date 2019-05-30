using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TshirtStockMgtApp.App.Utility
{
    public class CustomCommand : ICommand
    {
        private Action<object> _execute;
        private Predicate<object> _canExecute;
        private ICommand saveCommand;
        private object canSaveCommand;

        public CustomCommand(Action<object> exec, Predicate<object> canExecute)
        {
            _execute = exec;
            _canExecute = canExecute;
        }

        public CustomCommand(ICommand saveCommand, object canSaveCommand)
        {
            this.saveCommand = saveCommand;
            this.canSaveCommand = canSaveCommand;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            bool b;
            if (_canExecute == null)
                b = true;
            else
                b = _canExecute(parameter);
            return b;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
