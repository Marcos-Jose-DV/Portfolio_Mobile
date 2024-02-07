using AppPortfolio.Data;
using AppPortfolio.Models;
using AppPortfolio.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AppPortfolio.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly AppDbContext _context;

        public ProjectRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Project> Projects => _context.Projects
            .OrderBy(Project => Project.CategoryName)
            .Include(Project => Project.ImageUrls);

        public IEnumerable<CategoryProject> categoryProjects => _context.CategoryProjects;

        public IEnumerable<Project> GetProjectsById(int id)
        {
            var projects = _context.Projects
                .Where(project => project.CategoryId == id)
                .Include(project => project.ImageUrls)
                .ToList();

            return projects;




        }
    }
}
