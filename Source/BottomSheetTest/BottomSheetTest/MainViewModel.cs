using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.Maui.BottomSheet.Navigation;

namespace BottomSheetTest;

public partial class MainViewModel(IBottomSheetNavigationService sheetSvc) : ObservableObject
{
    [RelayCommand]
    private async Task ShowBottomSheet()
    {
        await sheetSvc.NavigateToAsync(nameof(MyBottomSheet), configure:sheet =>
        {
            if (sheet.BindingContext is not MyBottomSheetViewModel vm) return;
            vm.Title = "Lorem ipsum";
            vm.Text = "Hello world";
        });
    }
}