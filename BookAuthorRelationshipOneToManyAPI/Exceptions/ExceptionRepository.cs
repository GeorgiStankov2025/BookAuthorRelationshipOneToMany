using BookAuthorRelationshipOneToManyAPI.Entities;

namespace BookAuthorRelationshipOneToManyAPI.Exceptions
{
    public class ExceptionRepository : IExceptionRepository
    {
        public async Task<Book> AuthorNotFound()
        {
            throw new Exception("The requested author was not found.");
        }

        public Task<Book> BookNotFound()
        {
            throw new NotImplementedException("The requested");
        }

        public Task<Book> InvalidAuthor()
        {
            throw new NotImplementedException();
        }

        public Task<Book> InvalidBook()
        {
            throw new NotImplementedException();
        }
    }
}
