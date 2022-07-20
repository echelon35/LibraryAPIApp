using Library.Core.Domain.Books;
using Library.Core.Domain.DAO;
using LibraryAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        #region Fields
        private readonly IBookRepository _context = null!;
        #endregion

        public BooksController(IBookRepository context)
        {
            _context = context;
        }

        /// <summary>
        /// Get the list of books
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetBooks()
        {
            var bookListFromDb = _context.GetAll();

            var bookList = bookListFromDb.Select(book => new BookDto { 
                Title = book.Title, 
                Artists = book.Artists.Select(artist => new ArtistDto { Firstname = artist.Firstname, Lastname = artist.Lastname }).ToList()
            }).ToList();

            return this.Ok(bookList);
        }

        public IActionResult PostBooks(Book book)
        {
            return this.Ok();
        }
    }
}
