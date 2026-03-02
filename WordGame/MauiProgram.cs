using Microsoft.Extensions.Logging;
using WordGame.Core.ViewModels;

namespace WordGame
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Registrierung des MainViewModels
            builder.Services.AddSingleton<MainViewModel>();
            // Registrierung der MainPage
            builder.Services.AddSingleton<MainPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
