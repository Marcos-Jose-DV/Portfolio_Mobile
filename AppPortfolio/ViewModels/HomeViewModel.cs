using AppPortfolio.Models;
using AppPortfolio.Repository.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AppPortfolio.ViewModels;

public partial class HomeViewModel : Global
{
    private readonly IProjectRepository _projectRepository;
    private readonly ICourseRepository _courseRepository;
    [ObservableProperty]
    IEnumerable<CategoryProject> _categoryProjects;

    [ObservableProperty]
    IEnumerable<CategoryCourse> _categoryCourses;

    [ObservableProperty]
    string _themeTitle;

    public HomeViewModel(IProjectRepository projectRepository, ICourseRepository courseRepository)
    {
        _projectRepository = projectRepository;
        _courseRepository = courseRepository;
        Application.Current.RequestedThemeChanged += Current_RequestedThemeChanged;
        Load();
    }

    private void Current_RequestedThemeChanged(object? sender, AppThemeChangedEventArgs e)
    {
        if (e.RequestedTheme == AppTheme.Light)
        {
            ThemeTitle = "☀️";
            return;
        }
        ThemeTitle = "🌑";
    }

    private void Load()
    {
        CategoryProjects = _projectRepository.categoryProjects;
        CategoryCourses = _courseRepository.CategoryCourses;

        var theme = Application.Current.RequestedTheme;
        if (theme == AppTheme.Light)
        {
            ThemeTitle = "☀️";
            return;
        }
        ThemeTitle = "🌑";
    }
    public ICommand GetProjectByNameCommand =>
        new Command<int>(GetProjectByName);

    public ICommand GetCourseByNameCommand =>
        new Command<int>(GetCourseByName);
    public ICommand ContactCommand =>
        new Command<string>(Contact);

    public ICommand CurrentThemeCommand =>
        new Command(CurrentTheme);
    private void CurrentTheme()
    {
        var theme = Application.Current.RequestedTheme;

        if (theme == AppTheme.Light)
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
            return;
        }
        Application.Current.UserAppTheme = AppTheme.Light;
    }

    private async void Contact(string url)
    {
        try
        {
            Uri uri = new Uri(url);
            BrowserLaunchOptions options = new BrowserLaunchOptions()
            {
                LaunchMode = BrowserLaunchMode.SystemPreferred,
                TitleMode = BrowserTitleMode.Hide,
                PreferredToolbarColor = Colors.Black,
                PreferredControlColor = Colors.SandyBrown
            };

            await Browser.Default.OpenAsync(uri, options);
        }
        catch (Exception ex)
        {
            // An unexpected error occurred. No browser may be installed on the device.
        }
    }

    private async void GetCourseByName(int id)
    {
        await Shell.Current.GoToAsync($"DetailsPage?Course={id}");
    }

    private async void GetProjectByName(int id)
    {
        await Shell.Current.GoToAsync($"DetailsPage?Project={id}");
    }
}
