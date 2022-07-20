using Library.Core.Domain.Artists;
using Library.Core.Domain.Books;
using Library.Core.Domain.DAO;
using LibraryAPI.Controllers;
using LibraryAPI.DTO;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace TestLibraryAPI
{
    public class BookControllerUnitTest
    {
        [Fact]
        public void ShouldReturnListOfBooks()
        {
            Artist Author1 = new Artist();
            Artist Author2 = new Artist();

            // ARRANGE
            var expectedList = new List<Book>()
            {
                new Book(){Id=1,Title = "Pourquoi la Terre tremble ?",Artists=new List<Artist>{Author1,Author2} },
                new Book(){Id=2,Title = "Terre(s)",Artists=new List<Artist>{Author2}}
            };

            var repositoryMock = new Mock<IBookRepository>();
            repositoryMock.Setup(item => item.GetAll()).Returns(expectedList);
            var controller = new BooksController(repositoryMock.Object);

            // ACT
            var result = controller.GetBooks();

            // ASSERT
            Assert.NotNull(result);
            ObjectResult okResult = result as OkObjectResult;

            Assert.IsType<List<BookDto>>(okResult.Value);
            Assert.NotNull(okResult.Value);

            List<BookDto> list = okResult.Value as List<BookDto>;
            Assert.True(list.Count == expectedList.Count());
        }

        [Fact]
        public void ShouldAddBook()
        {
            var artist = new Artist() { Firstname = "Alain", Lastname = "Gautier" };
            var newBook = new Book() { Title = "L'Elysée du Géologue", Artists = new List<Artist>() { artist } };

            var repositoryMock = new Mock<IBookRepository>();

            var controller = new BooksController(repositoryMock.Object);
            var result = controller.PostBooks(newBook);

            Assert.NotNull(result);
            ObjectResult okResult = result as OkObjectResult;

        }
    }
}