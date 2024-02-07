namespace AppPortfolio.Models;

public class GetImageUrl
{
    public GetImageUrl(int id, string imageUrl, int projectId)
    {
        Id = id;
        ImageUrl = imageUrl;
        ProjectId = projectId;
    }

    public int Id { get; set; }
    public string ImageUrl { get; set; }
    public int ProjectId { get; set; }
}
