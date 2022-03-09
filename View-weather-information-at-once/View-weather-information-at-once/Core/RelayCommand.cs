using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View_weather_information_at_once.Core
{
	public class RelayCommand : ICommand
	{
		private Action<object>? _excute;
		private Func<object, bool>? _canExcute;

		public event EventHandler? CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public RelayCommand(Action<object> excute, Func<object, bool>? canExecute = null)
		{
			_excute = excute;
			_canExcute = canExecute;
		}

		public bool CanExecute(object? parameter)
		{
			return _canExcute == null || _canExcute(parameter);
		}

		public void Execute(object? parameter)
		{
			_excute(parameter);
		}
	}
}
