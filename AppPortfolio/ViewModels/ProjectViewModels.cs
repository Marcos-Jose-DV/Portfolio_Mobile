using AppPortfolio.Models;
using AppPortfolio.Repository.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AppPortfolio.ViewModels;

public partial class ProjectViewModels : Global
{
    private readonly IProjectRepository _projectRepository;

    [ObservableProperty]
    IEnumerable<CategoryProject> _projects;

    [ObservableProperty]
    private string _recentProject = "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fmarket01.png?alt=media&token=219eb0f6-58b8-444f-83a6-044195c98cf1";

    public ProjectViewModels(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
        Projects = _projectRepository.categoryProjects;
    }

    public ICommand GetProjectByNameCommand =>
        new Command<int>(GetProjectByName);

    private async void GetProjectByName(int id)
    {
        await Shell.Current.GoToAsync($"ProjectDetailsPage?name={id}");
    }
}
