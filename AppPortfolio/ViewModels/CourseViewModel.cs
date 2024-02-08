using AppPortfolio.Models;
using AppPortfolio.Repository.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AppPortfolio.ViewModels;

public partial class CourseViewModel : Global
{
    private readonly ICourseRepository _courseRepository;

    [ObservableProperty]
    IEnumerable<CategoryCourse> _CategoryCourses;

    [ObservableProperty]
    private string _recentProject = "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fmarket01.png?alt=media&token=219eb0f6-58b8-444f-83a6-044195c98cf1";

    public CourseViewModel(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;

        Load();
    }

    private void Load()
    {
        CategoryCourses = _courseRepository.CategoryCourses;
    }

    public ICommand GetCourseByNameCommand =>
        new Command<int>(GetCourseByName);

    private async void GetCourseByName(int id)
    {
        await Shell.Current.GoToAsync($"DetailsPage?Course={id}");
    }
}
