using noahAPI.Domain.Managers.Repositories;
using noahAPI.Domain.Models.DTOs;
using noahAPI.Domain.Models.Entities;

namespace noahAPI.Domain.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        
        public List<BookResponse> GetAll()
        {
            var books = _bookRepository.GetAll();
            var result = new List<BookResponse>();
            foreach (var book in books)
            {
                result.Add(new BookResponse
                {
                    Name = book.Name,
                    Description = book.Description,
                    Price = book.Price
                });
            }
            return result;
        }

        public Book Create(CreateBookRequest bookRequest)
        {
            var book = new Book()
            {
                Name = bookRequest.Name,
                Description = bookRequest.Description,
                Price = bookRequest.Price
            };
            var result = _bookRepository.Create(book);
            if(result)
                return book;
            return null;
        }
    }
}
