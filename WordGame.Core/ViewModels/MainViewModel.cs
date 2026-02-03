using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WordGame.Core.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string _output = string.Empty;

    [ObservableProperty]
    private string _input = string.Empty;

    [RelayCommand]
    private void Add()
    {

    }
}