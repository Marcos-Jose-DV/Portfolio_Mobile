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

    public HomeViewModel(IProjectRepository projectRepository, ICourseRepository courseRepository)
    {
        _projectRepository = projectRepository;
        _courseRepository = courseRepository;
       
        Load();
    }

    private void Load()
    {
        CategoryProjects = _projectRepository.categoryProjects;
        CategoryCourses = _courseRepository.CategoryCourses;
    }

    public ICommand GetProjectByNameCommand =>
        new Command<int>(GetProjectByName);

    private async void GetProjectByName(int id)
    {
        await Shell.Current.GoToAsync($"ProjectDetailsPage?name={id}");
    }

}
