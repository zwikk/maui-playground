using System.Diagnostics;
using Microsoft.AppCenter.Analytics;
using Microsoft.Extensions.Logging;

namespace VsCodeTest;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		//_ = TestAnalyticsAsync();

		return builder.Build();
	}

	static async Task TestAnalyticsAsync()
	{
		Analytics.StartSession();
		Analytics.TrackEvent("Hello world", null);

		if (await Analytics.IsEnabledAsync())
		{
			Console.WriteLine("Analytics enabled");
		}
		else
		{
			Console.WriteLine("Analytics not enabled");
		}
	}
}
