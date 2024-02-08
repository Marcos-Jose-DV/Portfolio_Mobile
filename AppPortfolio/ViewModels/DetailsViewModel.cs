using AppPortfolio.Models;
using AppPortfolio.Repository.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace AppPortfolio.ViewModels
{
    public partial class DetailsViewModel : Global, IQueryAttributable
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ICourseRepository _courseRepository;
        [ObservableProperty]
        IEnumerable<Course> _courses;
        [ObservableProperty]
        IEnumerable<Project> _project;

        [ObservableProperty]
        IEnumerable<object> _datas;


        public DetailsViewModel(IProjectRepository projectRepository, ICourseRepository courseRepository)
        {
            _projectRepository = projectRepository;
            _courseRepository = courseRepository;
        }
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            var key = query.Keys.First();
            int id;
            if (key.Equals("Course"))
            {
                id = Convert.ToInt32(query["Course"]);
                LoadCourse(id);
                return;
            }

            id = Convert.ToInt32(query["Project"]);
            LoadProject(id);
        }
        private void LoadCourse(int id)
        {
            Datas = _courseRepository.GetCoursesByid(id);
        }
        private void LoadProject(int id)
        {
            Datas = _projectRepository.GetProjectsById(id);
        }
    }
}
