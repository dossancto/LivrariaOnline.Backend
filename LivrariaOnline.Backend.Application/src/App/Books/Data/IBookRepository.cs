using LivrariaOnline.Backend.Application.App.Books.Entities;
using LivrariaOnline.Backend.Application.App.Domain.Enums;

namespace LivrariaOnline.Backend.Application.App.Books.Data;

public interface IBookRepository
{
    Task<BookEntity> Save(BookEntity book);
    Task<BookEntity> Update(BookEntity book);

    Task ChangeStatus(ProductAvaibitilyStatus newStatus);

    Task Delete(string id);

    Task<BookEntity> GetById(string id);
    Task<IEnumerable<BookEntity>> GetAll(int limit = 10);
}
