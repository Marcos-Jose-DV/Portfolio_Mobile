namespace AppPortfolio.Models;

public class Course
{
    public Course(int id, string name, string description, string hours, string imageUrl, int categoryId, string categoryName)
    {
        Id = id;
        Name = name;
        Description = description;
        Hours = hours;
        ImageUrl = imageUrl;
        CategoryId = categoryId;
        CategoryName = categoryName;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Hours { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
