using BookAuthorRelationshipOneToManyAPI.Data;
using BookAuthorRelationshipOneToManyAPI.Entities;

namespace BookAuthorRelationshipOneToManyAPI.Repositories
{
    public interface IBookRepository
    {

        Task<Book> CreateBook(Book book,Author author);
        Task<Book> RemoveBook(string name);
        Task<Book> GetBookByName(string name);
        Task<List<Book>> GetAllBooks();
    }
}
