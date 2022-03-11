using System.ComponentModel;
using System.Runtime.CompilerServices;
using View_weather_information_at_once.Core;
using View_weather_information_at_once.MVVM.Model;

namespace View_weather_information_at_once.MVVM.ViewModel
{
	public class MainViewModel
	{
		public MainModel MainModel { get; set; } = new MainModel();


		public MainViewModel()
		{
			MainModel.OverViewCommand = new RelayCommand(o =>
			{
				MainModel.OverViewVM = new OverViewViewModel();
				MainModel.CurrentView = MainModel.OverViewVM;
			});


		}

	}
}
