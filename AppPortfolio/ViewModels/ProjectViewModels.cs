using AppPortfolio.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AppPortfolio.ViewModels;

public partial class ProjectViewModels : Global
{
    [ObservableProperty]
    List<Category> _projects;

    public ICommand GetProjectByNameCommand =>
        new Command<int>(GetProjectByName);

    private async void GetProjectByName(int id)
    {
        await Shell.Current.GoToAsync($"ProjectDetailsPage?name={id}");
    }

    public ProjectViewModels()
    {
        Projects = SeedData.GetCategories();
    }
}
