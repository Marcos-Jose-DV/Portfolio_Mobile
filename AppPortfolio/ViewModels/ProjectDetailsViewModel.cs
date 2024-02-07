using AppPortfolio.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AppPortfolio.ViewModels
{
    public partial class ProjectDetailsViewModel : Global, IQueryAttributable
    {
        [ObservableProperty]
        List<Project> _projects;

        [ObservableProperty]
        List<GetImageUrl> _banners;
   
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            var id = Convert.ToInt32(query["name"]);
            Projects = SeedData.GetProjects().Where(project=>project.CategoryId == id).ToList();
            Banners = Projects[0].ImageUrls;
        }
        private void Load()
        {

        }
    }
}
