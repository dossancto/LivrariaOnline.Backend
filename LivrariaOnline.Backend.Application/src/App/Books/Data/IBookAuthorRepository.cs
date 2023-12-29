using LivrariaOnline.Backend.Application.App.Books.Entities;

namespace LivrariaOnline.Backend.Application.App.Books.Data;

public interface IBookAuthorRepository
{
    Task<BookAuthorEntity> Save(BookAuthorEntity book);
    Task<BookAuthorEntity> Update(BookAuthorEntity book);

    Task<BookAuthorEntity> GetByid(string id);
}
