namespace AppPortfolio.Models;

public class CategoryCourse
{
    public CategoryCourse(int id, string name, string imageUrl)
    {
        Id = id;
        Name = name;
        ImageUrl = imageUrl;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
}
