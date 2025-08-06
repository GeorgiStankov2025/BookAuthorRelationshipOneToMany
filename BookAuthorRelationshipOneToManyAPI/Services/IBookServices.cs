using BookAuthorRelationshipOneToManyAPI.Repositories;
using BookAuthorRelationshipOneToManyAPI.Entities;

namespace BookAuthorRelationshipOneToManyAPI.Services
{
    public interface IBookServices
    {
        Task<Book> CreateBookService(Book book,Author author);
        Task<Book> RemoveBookService(string name);
        Task<Book> GetBookByNameService(string name);
        Task<List<Book>> GetAllBooksService();

    }
}
