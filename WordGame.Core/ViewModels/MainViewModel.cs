using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WordGame.Data;
using WordGame.Data.Models;

namespace WordGame.Core.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private Game _game = new Game();
    private IRepository _repository;

    public MainViewModel(IRepository repository)
    {
        this._repository = repository;
    }

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

    [ObservableProperty]
    private string _status = string.Empty;

    [RelayCommand]
    private void Add()
    {
        try
        {
            bool result = this._game.Add(this.Input);
            if (result)
            {
                // save word
                Word w = new Word() { value = this.Input };
                this._repository.Add(w);

                // reset form
                this.Output = this._game.Get;
                this.Input = string.Empty;
                this.Status = string.Empty;
            }
            else            
            {
                this.Status = "Das Wort ist falsch.";
            }
        }
        catch (WordNotAllowedException we)
        {
            this.Status = we.Message;
        }
        
    }
}