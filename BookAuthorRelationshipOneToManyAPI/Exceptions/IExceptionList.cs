using BookAuthorRelationshipOneToManyAPI.Entities;

namespace BookAuthorRelationshipOneToManyAPI.Exceptions
{
    public interface IExceptionList
    {
        Task<Book> InvalidBook();
        Task<Book> BookNotFound();
        Task<Book> InvalidAuthor();
        Task<Book> AuthorNotFound();
        Task<Book> BookRemoved();
        Task<Book> ErrorRemovingBook();

    }
}
