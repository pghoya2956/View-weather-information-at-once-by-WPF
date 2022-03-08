using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace View_weather_information_at_once.Model
{
	public class MainModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string? name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		private int _currentView;
		public int CurrentView 
		{
			get => _currentView;
			set 
			{ 
				_currentView = value;
				OnPropertyChanged();
			}
		}
	}
}
