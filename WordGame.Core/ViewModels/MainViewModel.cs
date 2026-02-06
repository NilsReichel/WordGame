using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WordGame.Core.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private Game _game = new Game();

    [ObservableProperty]
    private bool _doubleWordsAllowed = false;

    partial void OnDoubleWordsAllowedChanged(bool value)
    {
        this._game.AllowDoubleWords(value);
    }

    [ObservableProperty]
    private string _output = string.Empty;

    [ObservableProperty]
    private string _input = string.Empty;

    [RelayCommand]
    private void Add()
    {
        this._game.Add(this.Input);
        this.Output = this._game.Get;
        this.Input = string.Empty;
    }
}