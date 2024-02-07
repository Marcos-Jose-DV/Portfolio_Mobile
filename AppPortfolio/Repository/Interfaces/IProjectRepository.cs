using AppPortfolio.Models;

namespace AppPortfolio.Repository.Interfaces;

public interface IProjectRepository
{
    IEnumerable<Project> Projects { get; }
    IEnumerable<CategoryProject> categoryProjects { get; }

    IEnumerable<Project> GetProjectsById(int id);
}
