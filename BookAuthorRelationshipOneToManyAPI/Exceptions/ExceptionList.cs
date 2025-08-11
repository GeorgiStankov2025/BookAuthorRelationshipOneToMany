using BookAuthorRelationshipOneToManyAPI.Entities;

namespace BookAuthorRelationshipOneToManyAPI.Exceptions
{
    public class ExceptionList : IExceptionList
    {
        public Task<Book> AuthorNotFound()
        {
            throw new Exception("The requested author was not found.");
        }

        public Task<Book> BookNotFound()
        {
            throw new Exception("The requested book was not found");
        }

        public Task<Book> InvalidAuthor()
        {
            throw new Exception("Invalid author properties.");
        }

        public Task<Book> InvalidBook()
        {
          throw new Exception("Invalid book properties. The book properties are not properly set or the book already exsists.");
        }

        public Task<Book> BookRemoved()
        {

          throw new Exception("The book is removed");

        }

        public Task<Book> ErrorRemovingBook()
        {

            throw new Exception("An error occurred while attempting to remove the book");
        
        }

        public Task<Book> ErrorCreatingBook()
        {
            throw new Exception("Ïnvalid number of pages property!");
        }

        public Task<Book> NoQuantity()
        {
            throw new Exception("Invalid quantity property");
        }
    }
}
