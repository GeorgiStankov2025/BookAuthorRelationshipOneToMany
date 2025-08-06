using BookAuthorRelationshipOneToManyAPI.Repositories;
using BookAuthorRelationshipOneToManyAPI.Entities;

namespace BookAuthorRelationshipOneToManyAPI.Services
{
    public interface IBookServices
    {
        Task<Book> CreateBookService(Book book);
        Task<Book> RemoveBookService(Guid Id);
        Task<Book> GetBookByNameService(Guid Id);
        Task<List<Book>> GetAllBooksService();

    }
}
