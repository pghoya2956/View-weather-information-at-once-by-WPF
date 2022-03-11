using System.ComponentModel;
using System.Runtime.CompilerServices;
using View_weather_information_at_once.Core;
using View_weather_information_at_once.MVVM.Model;

namespace View_weather_information_at_once.MVVM.ViewModel
{
	public class MainVM
	{
		private object _currentView;
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

		public OverViewVM? OverViewVM { get; set; }

		public MainVM()
		{
			CurrentView = new OverViewVM();

			OverViewCommand = new RelayCommand(o =>
			{
				CurrentView = new OverViewVM();
			});
		}



		/// <summary>
		/// INotifyPropertyChaned
		/// </summary>
		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged([CallerMemberName] string? name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}
}
