using LivrariaOnline.Backend.Application.App.Domain.Entities;

namespace LivrariaOnline.Backend.Application.App.Books.Entities;

public class BookEntity : ProductEntity
{
    public string Id { get; set; } = default!;

    public string Name { get; set; } = default!;

    public List<string> Categories { get; set; } = default!;

    public string CapaImgUrl { get; set; } = default!;

    public string Sumary { get; set; } = default!;

    public int PagesCount { get; set; } = 0;

    public BookAuthorEntity Author { get; set; } = default!;

    public DateTime ReleaseDate { get; set; } = DateTime.UtcNow;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
