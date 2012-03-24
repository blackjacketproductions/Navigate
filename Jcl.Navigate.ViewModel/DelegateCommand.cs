using System;
using System.Windows.Input;
using Windows.UI.Xaml.Input;

namespace Jcl.Navigate.ViewModel
{
    public class DelegateCommand<T> : ICommand
    {
        readonly Action<T> callback;

        public DelegateCommand(Action<T> handler)
        {
            callback = handler;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (callback != null) callback((T)parameter);
        }
    }
}