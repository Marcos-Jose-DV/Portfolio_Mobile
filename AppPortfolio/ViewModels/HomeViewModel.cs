using AppPortfolio.Models;
using AppPortfolio.Repository.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AppPortfolio.ViewModels;

public partial class HomeViewModel : Global
{
    private readonly IProjectRepository _projectRepository;
    [ObservableProperty]
    IEnumerable<CategoryProject> _categories;

    public HomeViewModel(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
        Categories = _projectRepository.categoryProjects;
    }
    public ICommand GetProjectByNameCommand =>
        new Command<int>(GetProjectByName);

    private async void GetProjectByName(int id)
    {
        await Shell.Current.GoToAsync($"ProjectDetailsPage?name={id}");
    }

}
