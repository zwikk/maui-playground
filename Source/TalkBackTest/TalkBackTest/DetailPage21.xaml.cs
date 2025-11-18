namespace TalkBackTest;

public partial class DetailPage21
{
    public DetailPage21()
    {
        InitializeComponent();
    }
    
    private void OnDetail211Clicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new DetailPage211());
    }
}