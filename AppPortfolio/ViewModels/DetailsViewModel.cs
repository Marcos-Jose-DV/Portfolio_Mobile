using AppPortfolio.Models;
using AppPortfolio.Repository.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace AppPortfolio.ViewModels
{
    public partial class DetailsViewModel : Global, IQueryAttributable
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ICourseRepository _courseRepository;

        [ObservableProperty]
        IEnumerable<object> _datas;

        [ObservableProperty]
        bool _isVisiblePopup, _isEnableImage;

        [ObservableProperty]
        string _imagePopup, _emptyViewTitle;

        [RelayCommand]
        private async void ShowPopup(string image)
        {
            ImagePopup = image;
            IsEnableImage = !IsEnableImage;
            await Task.Delay(1000);
            IsVisiblePopup = !IsVisiblePopup;
        }

        [RelayCommand]
        private void ClosePopup()
        {
            IsEnableImage = !IsEnableImage;
            IsVisiblePopup = !IsVisiblePopup;
        }

        public DetailsViewModel(IProjectRepository projectRepository, ICourseRepository courseRepository)
        {
            _projectRepository = projectRepository;
            _courseRepository = courseRepository;
        }
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            IsVisiblePopup = false;
            IsEnableImage = true;
            Datas = null;

            var key = query.Keys.First();
            int id;

            if (key.Equals("Course"))
            {
                id = Convert.ToInt32(query[key]);
                LoadCourse(id);
                return;
            }

            id = Convert.ToInt32(query[key]);
            LoadProject(id);
        }
        private void LoadCourse(int id)
        {
            var datas = _courseRepository.GetCoursesByid(id);
            if (datas.Any())
            {
                Datas = datas;
                return;
            }

            LoadEmptyViewTitle("cursos");
        }
        private void LoadProject(int id)
        {
            var datas = _projectRepository.GetProjectsById(id);
            if (datas.Any())
            {
                Datas = datas;
                return;
            }
            LoadEmptyViewTitle("projetos");
            Datas = datas;
        }

        private void LoadEmptyViewTitle(string title)
        {
            title = title == "Course" ? "cursos" : "projetos";
            EmptyViewTitle = $"Vou adicionar {title} nessa categoria mais tarde...";
        }
    }
}
