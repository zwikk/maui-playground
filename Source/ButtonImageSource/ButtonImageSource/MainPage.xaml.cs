namespace ButtonImageSource;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Btn1.IsVisible = true;
		Btn2.IsVisible = true;
    }
}


