using CommunityToolkit.Maui.Views;

namespace PopupBug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		this.ShowPopup(new MyPopup());
	}
}


