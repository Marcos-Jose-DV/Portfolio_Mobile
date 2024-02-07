using AppPortfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace AppPortfolio.Data;

public class AppDbContext : DbContext
{
    public DbSet<Project> Projects { get; set; }
    public DbSet<CategoryProject> CategoryProjects { get; set; }
    public DbSet<GetImageUrl> ImageUrls { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CategoryCourse> CategoryCourses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("AppPortfolio");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Project>().HasData(
             new()
             {
                 Id = 1,
                 Name = "4C Market",
                 Description = "OFERECEU AOS FUNCIONÁRIOS A OPORTUNIDADE DE TROCAR MOEDAS VIRTUAIS POR PRODUTOS, INCENTIVANDO UM AMBIENTE DE TRABALHO RECOMPENSADOR.",
                 CategoryId = 3,
                 CategoryName = "Mobile"
             },
            new()
            {
                Id = 2,
                Name = "App Doc",
                Description = "",
                CategoryId = 4,
                CategoryName = "Desktop"

            },
            new()
            {
                Id = 3,
                Name = "Site Lanche",
                Description = "",
                CategoryId = 2,
                CategoryName = "Front-End"
            },
             new()
             {
                 Id = 4,
                 Name = "Portfolio Web",
                 Description = "OFERECEU AOS FUNCIONÁRIOS A OPORTUNIDADE DE TROCAR MOEDAS VIRTUAIS POR PRODUTOS, INCENTIVANDO UM AMBIENTE DE TRABALHO RECOMPENSADOR.",
                 CategoryId = 2,
                 CategoryName = "Front-End"
             }
            );

        builder.Entity<GetImageUrl>().HasData(

            new GetImageUrl(1, "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fmarket01.png?alt=media&token=219eb0f6-58b8-444f-83a6-044195c98cf1", 1),
            new GetImageUrl(2, "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fmarket02.png?alt=media&token=30f582af-93f0-434a-9a64-6eb64ae1a93c", 1),
            new GetImageUrl(3, "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fmarket03.png?alt=media&token=d5092136-db13-4e8b-a148-c4fd76e41b51", 1),
            new GetImageUrl(4, "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fmarket04.png?alt=media&token=9ce10979-1f82-4360-a46f-e01fce887097", 1),
            new GetImageUrl(5, "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fportifolioweb%2Fportfolioweb01.png?alt=media&token=65bb7495-d0d6-412e-8c97-66f690edf06f", 4),
            new GetImageUrl(6, "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fportifolioweb%2Fportifolioweb02.png?alt=media&token=3e95bffd-bdc6-428b-970d-10ceaaf7d7b5", 4),
            new GetImageUrl(7, "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fportifolioweb%2Fportifolioweb03.png?alt=media&token=de8890b9-dcfe-4773-be2b-3f8d2a287c9d", 4),
            new GetImageUrl(8, "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fportifolioweb%2Fportifolioweb04.png?alt=media&token=69cb683e-ae51-4101-b71e-612da6b4b685", 4),
            new GetImageUrl(9, "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/project%2Fportifolioweb%2Fportifolioweb05.png?alt=media&token=6b84ae91-a1ca-4a8d-b8cc-368380074a94", 4)
            );

        builder.Entity<CategoryProject>().HasData(
             new CategoryProject(1, "Back-End", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/category%2Fcateimg01.png?alt=media&token=9c634336-1c5f-4e0c-bf29-af66924007a7"),
            new CategoryProject(2, "Front-End", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/category%2Fcateimg02.png?alt=media&token=354eca30-7fe0-40fa-8fc2-1ee31ff21903"),
            new CategoryProject(3, "Mobile", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/category%2Fcateimg03.png?alt=media&token=c58a03a6-4ce6-4439-9f94-65bfbd78c70d"),
            new CategoryProject(4, "Desktop", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/category%2Fcateimg04.png?alt=media&token=56f8f7f6-47d6-4c68-86dd-c395746bbd3a"),
            new CategoryProject(5, "Devops", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/category%2Fcateimg05.png?alt=media&token=9771f6c1-8971-4e91-9443-d96b0b179e0f"),
            new CategoryProject(6, "Logíca", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/category%2Fcateimg06.png?alt=media&token=ff0a6b09-9fb7-4839-a299-b451a37998cc")
            );
    }
}
