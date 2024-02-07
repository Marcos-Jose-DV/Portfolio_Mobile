using AppPortfolio.Models;

namespace AppPortfolio.Repository.Interfaces;

public interface ICourseRepository
{
    public IEnumerable<CategoryCourse> CategoryCourses { get; }
}
