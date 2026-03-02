using WordGame.Core.ViewModels;

namespace WordGame;

public partial class MainPage : ContentPage
{
   
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
