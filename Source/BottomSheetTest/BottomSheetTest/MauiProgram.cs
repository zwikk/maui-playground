using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Plugin.Maui.BottomSheet.Hosting;

namespace BottomSheetTest;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseBottomSheet()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddTransient<MainPage, MainViewModel>();
        builder.Services.AddBottomSheet<MyBottomSheet, MyBottomSheetViewModel>(nameof(MyBottomSheet));

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}