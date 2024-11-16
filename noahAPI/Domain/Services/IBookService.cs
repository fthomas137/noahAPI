using noahAPI.Domain.Models.DTOs;
using noahAPI.Domain.Models.Entities;

namespace noahAPI.Domain.Services
{
    public interface IBookService
    { 
        List<BookResponse> GetAll();
        Book Create(CreateBookRequest book);
    }
}
