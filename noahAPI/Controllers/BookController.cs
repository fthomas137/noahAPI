using Microsoft.AspNetCore.Mvc;
using noahAPI.Domain.Models.DTOs;
using noahAPI.Domain.Models.Entities;
using noahAPI.Domain.Services;

namespace noahAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var results = _bookService.GetAll();

            return Ok(results);
        }

        [HttpPost]
        public IActionResult Create(CreateBookRequest book)
        {
            if (book is null)
                return BadRequest();
            var newBook = _bookService.Create(book);
            if(newBook is null)
                return BadRequest();
            return Ok(newBook);
        }
    }
}
