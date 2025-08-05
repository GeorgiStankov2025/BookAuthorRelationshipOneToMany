using BookAuthorRelationshipOneToManyAPI.Data;
using BookAuthorRelationshipOneToManyAPI.Entities;

namespace BookAuthorRelationshipOneToManyAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Task<Book> CreateBook(Book book,Author author)
        {
            
           

        }

        public Task<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookByName(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<Book> RemoveBook()
        {
            throw new NotImplementedException();
        }

        public Task<Book> UpdateBook()
        {
            throw new NotImplementedException();
        }
    }
}
