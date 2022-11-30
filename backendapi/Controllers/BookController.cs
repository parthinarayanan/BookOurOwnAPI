using Microsoft.AspNetCore.Mvc;
using backendapi.Models;
namespace Backendapi.Controllers;
[ApiController]
[Route("api/Books")]

public class BookController :ControllerBase
{
    private readonly LibrarysContext DB;
    public BookController (LibrarysContext db)
    {
        this.DB = db;
    }
    [HttpGet("GetAllLibraryBooks")]
    public Book GetAllLibraryBooks(string BooksNames)
    {
        try
        {
            return DB.Books.Where(e =>e.BookName.Equals(BooksNames)).FirstOrDefault();
        }
        catch(System.Exception)
        {
            throw;
        }
    }
}