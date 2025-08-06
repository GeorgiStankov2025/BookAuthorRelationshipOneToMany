using BookAuthorRelationshipOneToManyAPI.Entities;

namespace BookAuthorRelationshipOneToManyAPI.Exceptions
{
    public interface IExceptionRepository
    {
        Task<Book> InvalidBook();
        Task<Book> BookNotFound();
        Task<Book> InvalidAuthor();
        Task<Book> AuthorNotFound();

    }
}
