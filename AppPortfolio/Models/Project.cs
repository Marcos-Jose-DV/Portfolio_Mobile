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
public class GetImageUrl
{
    public string ImageUrl { get; set; }
}

public record Category(int Id, string Name);

public static class SeedData
{
    public static List<Project> GetProjects()
    {

        var projects = new List<Project>
        {
            new()
            {
                Id = 1,
                Name = "4C Market",
                Description = "OFERECEU AOS FUNCIONÁRIOS A OPORTUNIDADE DE TROCAR MOEDAS VIRTUAIS POR PRODUTOS, INCENTIVANDO UM AMBIENTE DE TRABALHO RECOMPENSADOR.",
                ImageUrls =
                [
                    new() { ImageUrl = "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fmarket01.png?alt=media&token=219eb0f6-58b8-444f-83a6-044195c98cf1" },
                    new() { ImageUrl = "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fmarket02.png?alt=media&token=30f582af-93f0-434a-9a64-6eb64ae1a93c" },
                    new() { ImageUrl = "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fmarket03.png?alt=media&token=d5092136-db13-4e8b-a148-c4fd76e41b51" },
                    new() { ImageUrl = "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fmarket04.png?alt=media&token=9ce10979-1f82-4360-a46f-e01fce887097" }
                ],
                CategoryId = 3,
                CategoryName = "Mobile"
            },
            new()
            {
                Id = 2,
                Name = "App Doc",
                Description = "",
                ImageUrls =
                [
                    new() { ImageUrl = "doc01.png" },
                    new() { ImageUrl = "doc02.png" },
                    new() { ImageUrl = "doc03.png" },
                    new() { ImageUrl = "doc04.png" }
                ],
                CategoryId = 4,
                CategoryName = "Desktop"
                
            },
            new()
            {
                Id = 3,
                Name = "Site Lanche",
                Description = "",
                ImageUrls =
                [
                    new() { ImageUrl = "web01.png" },
                    new() { ImageUrl = "web02.png" },
                    new() { ImageUrl = "web03_.png" },
                    new() { ImageUrl = "web04.png" }
                ],
                CategoryId = 2,
                CategoryName = "Front-End"
            },
             new()
            {
                Id = 3,
                Name = "Portfolio Web",
                Description = "OFERECEU AOS FUNCIONÁRIOS A OPORTUNIDADE DE TROCAR MOEDAS VIRTUAIS POR PRODUTOS, INCENTIVANDO UM AMBIENTE DE TRABALHO RECOMPENSADOR.",
                ImageUrls =
                [
                    new() { ImageUrl = "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fportifolioweb%2Fportfolioweb01.png?alt=media&token=65bb7495-d0d6-412e-8c97-66f690edf06f" },
                    new() { ImageUrl = "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fportifolioweb%2Fportifolioweb02.png?alt=media&token=3e95bffd-bdc6-428b-970d-10ceaaf7d7b5" },
                    new() { ImageUrl = "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fportifolioweb%2Fportifolioweb03.png?alt=media&token=de8890b9-dcfe-4773-be2b-3f8d2a287c9d" },
                    new() { ImageUrl = "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fportifolioweb%2Fportifolioweb04.png?alt=media&token=69cb683e-ae51-4101-b71e-612da6b4b685" },
                    new() { ImageUrl = "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fportifolioweb%2Fportifolioweb05.png?alt=media&token=6b84ae91-a1ca-4a8d-b8cc-368380074a94" }
                ],
                CategoryId = 3,
                CategoryName = "Front-End"
            }
        };


        return projects;
    }
    public static List<Category> GetCategories()
    {
        List<Category> categories =
        [
            new(1, "Back-End"),
            new(2, "Front-End"),
            new(3, "Mobile"),
            new(4, "Desktop"),
            new(5, "Devops"),
            new(6, "Logica de programação"),
        ];

        return categories;
    }
}
