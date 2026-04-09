using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using WordGame.Core.ViewModels;
using WordGame.Data;
using WordGame.Data.Services;

namespace WordGame
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Registrierung des MainViewModels
            builder.Services.AddSingleton<MainViewModel>();
            // Registrierung der MainPage
            builder.Services.AddSingleton<MainPage>();

            // Repositorys
            // Folgende Zeile wäre unlogisch, da vom Typ IRepository ein Objekt werstellt werden würde
            // => bei einer Schnittstelle nicht möglich!
            // builder.Services.AddSingleton<IRepository>();
            builder.Services.AddSingleton<IRepository>(new XMLRepository());

#if DEBUG
            builder.Logging.AddDebug(); 
#endif

            return builder.Build();
        }
    }
}
