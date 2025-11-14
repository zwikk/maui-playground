namespace TalkBackTest;

public partial class DetailPage3
{
    public DetailPage3()
    {
        InitializeComponent();
    }
    
    private void OnDetail31Clicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new DetailPage31());
    }
}