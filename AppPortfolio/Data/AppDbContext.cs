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

        builder.Entity<Course>().HasData(
            new Course( 1, "C#", "Fundamentos do C#", "12 Hora(S)", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/Course%2Ffundamentoscsharp02.png?alt=media&token=7ccaa20f-33a4-425e-a7cd-4c9c1ab37eff", 1, "C#" ),
            new Course(2, "Razor Pages", "Uma visão geral sobre o ASP.NET Razor Pages", "1 Hora(S)", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/Course%2Frazorpages.png?alt=media&token=0e91c791-0b16-431a-b488-01dacc957092", 1, "C#"),
            new Course(3, "Algoritimo", "Algoritmo e Lógiva de programação 2022 - O curso Completo", "30.5 Hora(S)", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/Course%2Falgoritimo01.png?alt=media&token=2303fdb6-1071-477b-868c-d0bd550d02ec", 6, "Algoritmo"),
            new Course(4, "Algoritimo", "Lógica de Programação: começandoa desenvolver seus primeiros programas.", "20 Hora(S)", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/Course%2Flogi01.png?alt=media&token=b093fea2-a349-43ec-b59d-a059208d92f0", 6, "Algoritmo"),
            new Course(5, "Algoritimo", "Lógica de Programação: deixando os seus programas espertos.", "20 Hora(S)", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/Course%2Flogi02.png?alt=media&token=97d50a90-d0a6-4762-9e8d-83e5841cb637", 6, "Algoritmo"),
            new Course(6, "Algoritimo", "Lógica de Programação: mútiplos valores e módulos.", "20 Hora(S)", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/Course%2Flogi03.png?alt=media&token=0ae235a0-162e-455f-9c88-338d098e60b5", 6, "Algoritmo"),
            new Course(7, ".NET Maui", ".NET MAUI - Desenvolvendo um app de Controle Financeiro", "11 Hora(S)", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/Course%2Fnetmaui01.png?alt=media&token=05ff6f1d-acb6-4f73-a6f5-0615c322418d", 3, ".NET Maui"),
            new Course(8, ".NET Maui", ".NET MAUI - Desde las bases hasta Profesional | Android | IOS", "117.5 Hora(S)", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/Course%2Fnetmaui02.png?alt=media&token=04ac3204-4333-448c-a8b9-bf26212af1cd", 3, ".NET Maui"),
            new Course(9, "JavaScript", "Fundamentos do JavaScript", "30 Hora(S)", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/Course%2Fjs01.png?alt=media&token=f37f12c4-96ee-4845-a9ab-af2055a61a97", 5, "JavaScript"),
            new Course(10, "JavaScript", "Projeto de Sistemas Web", "30 Hora(S)", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/Course%2Fweb01.png?alt=media&token=c4e6a2a5-2f3d-431c-8de4-6a9c2e44fed2", 5, "JavaScript"),
            new Course(11, "HTML", "HTML: Entrodução ao desenvolvimento de páginas web", "20 Hora(S)", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/Course%2Fhtml01.png?alt=media&token=a09ae9e5-59ac-4b0e-9827-c0849a419338", 7, "HTML"),
            new Course(12, "HTML", "HTML: Tabelas e formulários", "20 Hora(S)", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/Course%2Fhtml02.png?alt=media&token=0a8f873b-eb82-498e-a6b0-219fadaebb9e", 7, "HTML"),
            new Course(13, "CSS", "CSS: folhas de estilo", "30 Hora(S)", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/Course%2Fcss01.png?alt=media&token=d59258ab-911b-49b2-b37c-1a532becd02c", 8, "CSS")
            );

        builder.Entity<CategoryCourse>().HasData(
            new CategoryCourse(1, "C#", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/CategoryCourse%2Fcourseimg01.png?alt=media&token=4c0949d5-c94e-4cd2-b83a-b64569c54a06"),
            new CategoryCourse(2, "Python", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/CategoryCourse%2Fcourseimg02.png?alt=media&token=8f810596-907c-4082-8e57-9d01eb5e160d"),
            new CategoryCourse(3, ".NET Maui", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/CategoryCourse%2Fcourseimg03.png?alt=media&token=e701d78c-3189-49fb-aeab-09dfd6f3ae38"),
            new CategoryCourse(4, "SQL", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/CategoryCourse%2Fcourseimg04.png?alt=media&token=922f9701-724e-4f46-8394-95ea31c90487"),
            new CategoryCourse(5, "JavaScript", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/CategoryCourse%2Fcourseimg05.png?alt=media&token=d973f42d-feeb-478d-815e-7c5301864a6d"),
            new CategoryCourse(6, "Algoritmo", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/CategoryCourse%2Fcourseimg06.png?alt=media&token=85721f30-2ba4-4120-9c9a-56a0c814830f"),
            new CategoryCourse(7, "HTML", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/CategoryCourse%2Fcourseimg07.png?alt=media&token=3365b807-833a-486f-bceb-aa024f523ffe"),
            new CategoryCourse(8, "CSS", "https://firebasestorage.googleapis.com/v0/b/portfoliomobile-c6703.appspot.com/o/CategoryCourse%2Fcourseimg08.png?alt=media&token=79663963-9fd3-4015-ad08-5d637db9d865")
            );
    }
}
