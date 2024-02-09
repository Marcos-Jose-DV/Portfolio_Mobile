using AppPortfolio.Data;
using AppPortfolio.Repository;
using AppPortfolio.Repository.Interfaces;
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

            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<HomeViewModel>();

            builder.Services.AddSingleton<AboutPage>();

            builder.Services.AddSingleton<ProjectPage>();
            builder.Services.AddSingleton<ProjectViewModels>();

            builder.Services.AddSingleton<DetailsPage>();
            builder.Services.AddSingleton<DetailsViewModel>();

            builder.Services.AddSingleton<CoursePage>();
            builder.Services.AddSingleton<CourseViewModel>();

            builder.Services.AddSingleton<GamePage>();
            builder.Services.AddSingleton<GameViewModel>();

            builder.Services.AddSingleton<IProjectRepository, ProjectRepository>();
            builder.Services.AddSingleton<ICourseRepository, CourseRepository>();

            builder.Services.AddDbContext<AppDbContext>();

            var dbContext = new AppDbContext();
            dbContext.Database.EnsureCreated();
            dbContext.Dispose();

            Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
