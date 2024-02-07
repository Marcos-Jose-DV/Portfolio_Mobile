using AppPortfolio.ViewModels;
using AppPortfolio.Views;
using Microsoft.Extensions.Logging;

namespace AppPortfolio
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
                    fonts.AddFont("NunitoSans-10pt-Bold.ttf", "NunitoSans-Bold");
                });

            builder.Services.AddSingleton<ProjectPage>();
            builder.Services.AddSingleton<ProjectViewModels>();

            builder.Services.AddSingleton<ProjectDetailsPage>();
            builder.Services.AddSingleton<ProjectDetailsViewModel>();

            Routing.RegisterRoute(nameof(ProjectDetailsPage), typeof(ProjectDetailsPage));

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
