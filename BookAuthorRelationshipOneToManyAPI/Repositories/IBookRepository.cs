using BookAuthorRelationshipOneToManyAPI.Data;
using BookAuthorRelationshipOneToManyAPI.Entities;

namespace BookAuthorRelationshipOneToManyAPI.Repositories
{
    public interface IBookRepository
    {

        Task<Book> CreateBook(Book book);
        Task<Book> RemoveBook(Guid Id);
        Task<Book> GetBookByName(Guid Id);
        Task<List<Book>> GetAllBooks();
    }
}
