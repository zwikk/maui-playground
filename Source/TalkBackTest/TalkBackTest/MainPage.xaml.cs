namespace TalkBackTest;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnDetail1Clicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new DetailPage1());
    }
    
    private void OnDetail2Clicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new DetailPage2());
    }
    
    private void OnDetail3Clicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new DetailPage3());
    }
}