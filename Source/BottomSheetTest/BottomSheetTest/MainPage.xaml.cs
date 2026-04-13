namespace BottomSheetTest;

public partial class MainPage
{
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        
        BindingContext = vm;
    }
}