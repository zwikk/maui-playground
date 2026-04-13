using CommunityToolkit.Mvvm.ComponentModel;

namespace BottomSheetTest;

public partial class MyBottomSheetViewModel : ObservableObject
{
    [ObservableProperty]
    public partial string? Title { get; set; }

    [ObservableProperty]
    public partial string? Text { get; set; }
}