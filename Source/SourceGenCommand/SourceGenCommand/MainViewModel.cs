using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SourceGenCommand;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    private Task DoSomethingAsync()
    {
        return Task.CompletedTask;
    }
    
    [RelayCommand]
    private Task DoSomethingElse()
    {
        return Task.CompletedTask;
    }
}