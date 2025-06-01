using Microsoft.Extensions.Logging;

namespace CadastroEventos
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
                    fonts.AddFont("OldStandardTT-Regular.ttf", "OldTT");
                    fonts.AddFont("OldStandardTT-Italic.ttf", "OldTTItalic");
                    fonts.AddFont("OldStandardTT-Bold.ttf", "OldTTBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
