using noahAPI.Domain.Models.Entities;

namespace noahAPI.Domain.Managers.Repositories
{
    public class BookRepository : IBookRepository
    {
        private List<Book> _books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Name = "Star Wars",
                Description = "Space Story",
                Price = 9.99m
            },
            new Book
            {
                Id = 2,
                Name = "Man on Mars",
                Description = "Space Story",
                Price = 9.99m
            },
            new Book
            {
                Id = 3,
                Name = "Of Mice And Men",
                Description = "Drama about mice that love to eat men.",
                Price = 9.99m
            }
        };


        public BookRepository()
        {
            
        }

        public List<Book> GetAll()
        {
            return _books;
        }

        public Book Create(Book book)
        {
            book.Id = _books.OrderBy(x => x.Id).Last().Id + 1;
            _books.Add(book);
            return book;
        }
    }
}
