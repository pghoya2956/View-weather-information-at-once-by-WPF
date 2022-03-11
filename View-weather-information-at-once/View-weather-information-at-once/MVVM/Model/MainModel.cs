using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View_weather_information_at_once.Core;
using View_weather_information_at_once.MVVM.ViewModel;

namespace View_weather_information_at_once.MVVM.Model
{
	public class MainModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string? name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}

		private object? _currentView;
		public object CurrentView
		{
			get => _currentView;
			set
			{
				_currentView = value;
				OnPropertyChanged();
			}
		}

		public RelayCommand? OverViewCommand { get; set; }

		public OverViewViewModel? OverViewVM { get; set; }

	}
}
