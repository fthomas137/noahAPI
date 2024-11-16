using noahAPI.Domain.Models.Entities;

namespace noahAPI.Domain.Managers.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book Create(Book book);

    }
}
