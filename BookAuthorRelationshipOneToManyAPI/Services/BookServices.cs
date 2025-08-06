using BookAuthorRelationshipOneToManyAPI.Exceptions;
using BookAuthorRelationshipOneToManyAPI.Entities;
using BookAuthorRelationshipOneToManyAPI.Repositories;

namespace BookAuthorRelationshipOneToManyAPI.Services
{
    public class BookServices(BookRepository bookRepository,ExceptionRepository exceptions ) :IBookServices
    {
        public async Task<Book> CreateBookService(Book book, Author author)
        {

            if (book == null)
            {

                return exceptions.InvalidBook;

            }


            return await bookRepository.CreateBook(book,author);


        }

        public Task<List<Book>> GetAllBooksService()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookByNameService(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Book> RemoveBookService(string name)
        {
            throw new NotImplementedException();
        }
    }
}
