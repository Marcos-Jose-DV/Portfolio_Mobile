using AppPortfolio.Models;
using AppPortfolio.Repository.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AppPortfolio.ViewModels
{
    public partial class ProjectDetailsViewModel : Global, IQueryAttributable
    {
        private readonly IProjectRepository _projectRepository;
        [ObservableProperty]
        IEnumerable<Project> _projects;

        public ProjectDetailsViewModel(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            var id = Convert.ToInt32(query["name"]);
            Projects = _projectRepository.GetProjectsById(id);
        }
        private void Load()
        {

        }
    }
}
