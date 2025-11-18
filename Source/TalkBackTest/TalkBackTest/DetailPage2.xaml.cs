namespace TalkBackTest;

public partial class DetailPage2
{
    public DetailPage2()
    {
        InitializeComponent();
    }
    
    private void OnDetail21Clicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new DetailPage21());
    }
}