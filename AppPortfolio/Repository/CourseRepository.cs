using AppPortfolio.Data;
using AppPortfolio.Models;
using AppPortfolio.Repository.Interfaces;

namespace AppPortfolio.Repository;

public class CourseRepository : ICourseRepository
{
    private readonly AppDbContext _context;

    public CourseRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<CategoryCourse> CategoryCourses => _context.CategoryCourses.ToList();
    public IEnumerable<Course> GetCoursesByid(int id)
    {
        var course = _context.Courses.Where(course=>course.CategoryId == id).ToList();

        return course;
    }
}