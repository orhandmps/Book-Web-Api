using BtkAkademi.Business.Concrete;
using BtkAkademi.DataAccess.Concrete;
using BtkAkademi.Domain.Entites;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IServiceManager manager;

        public BooksController(IServiceManager manager)
        {
            this.manager = manager;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            try
            {
                var books = manager.BookService.GetAll();
                return Ok(books);
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }

        }

        [HttpGet("{id:int}")]
        public IActionResult GetBook(int id)
        {

            try
            {
                var book = manager.BookService.Get(id);

                if (book is null)
                    return NotFound(); //404

                return Ok(book);
            }
            catch (Exception err)
            {
                throw new Exception($"Error {err.Message}");
            }
        }

        [HttpPost]
        public IActionResult AddBook(Book post)
        {
            try
            {
                if (post == null)
                    return BadRequest(); //400

                manager.BookService.Add(post);
                return StatusCode(201, post);
            }
            catch (Exception err)
            {
                throw new Exception($"Error {err.Message}");
            }
        }

        [HttpPut]
        public IActionResult UpdateBook(int id, Book post)
        {
            try
            {
                var book = manager.BookService.Get(id);
                if (book is null)
                    return NotFound();

                book.Title = post.Title;
                book.Price = post.Price;
                manager.BookService.Update(id, book);
                return Ok(book);
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                var book = manager.BookService.Get(id);
                if (book is null)
                    return BadRequest();

                manager.BookService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
