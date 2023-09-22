using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Extensions;

namespace AppThemeBug;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();


		var navigationPage = new NavigationPage(new MainPage());

		// set AppThemeColor
		var color = new AppThemeColor
		{
			Light = Colors.Red,
			Dark = Colors.Green
		};
		navigationPage.SetAppThemeColor(NavigationPage.BarBackgroundColorProperty, color);
		MainPage = new NavigationPage(new MainPage());
	}
}

