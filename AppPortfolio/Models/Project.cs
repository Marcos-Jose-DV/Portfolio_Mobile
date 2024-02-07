namespace AppPortfolio.Models;

public class Project()
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<GetImageUrl> ImageUrls { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}