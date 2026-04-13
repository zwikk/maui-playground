using Microsoft.Extensions.DependencyInjection;

namespace BottomSheetTest;

public partial class App : Application
{
    private readonly IServiceProvider _services;
    
    public App(IServiceProvider services)
    {
        InitializeComponent();
        _services = services;
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var page = _services.GetRequiredService<MainPage>();
        var navPage = new NavigationPage(page);

        // no bottomsheet with TabbedPage as root
        var tabbedPage = new TabbedPage();
        tabbedPage.Children.Add(navPage);
        return new Window(tabbedPage);

        // this works fine
        //return new Window(navPage);
    }
}