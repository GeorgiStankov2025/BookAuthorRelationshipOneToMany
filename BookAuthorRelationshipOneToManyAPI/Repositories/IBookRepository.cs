using BookAuthorRelationshipOneToManyAPI.Data;
using BookAuthorRelationshipOneToManyAPI.Entities;

namespace BookAuthorRelationshipOneToManyAPI.Repositories
{
    public interface IBookRepository
    {

        Task<Book> CreateBook(Book book);
        Task<Book> UpdateBook();
        Task<Book> RemoveBook();
        Task<Book> GetBookByName(string Name);
        Task<Book> GetAllBooks();
    }
}
