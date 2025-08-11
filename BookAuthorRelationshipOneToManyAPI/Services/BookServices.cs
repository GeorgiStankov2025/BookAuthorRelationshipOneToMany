using BookAuthorRelationshipOneToManyAPI.Exceptions;
using BookAuthorRelationshipOneToManyAPI.Entities;
using BookAuthorRelationshipOneToManyAPI.Repositories;
using System.Net.WebSockets;

namespace BookAuthorRelationshipOneToManyAPI.Services
{
    public class BookServices(IBookRepository bookRepository,IExceptionList exceptions ) :IBookServices
    {
        public async Task<Book> CreateBookService(Book book)
        {

            if (book is null)
            {

                return await exceptions.InvalidBook();

            }

            else if(book.NumberofPages<=0)
            {

                return await exceptions.ErrorCreatingBook();

            }

            else if(book.Quantity<=0)
            {

                return await exceptions.NoQuantity();

            }

            else if (book.Author is null)
            {

                return await exceptions.InvalidAuthor();

            }
            else
            {
                return await bookRepository.CreateBook(book);
            }

        }

        public async Task<List<Book>> GetAllBooksService()
        {
            
            var books = await bookRepository.GetAllBooks();

            return books;

        }

        public async Task<Book> GetBookByNameService(Guid Id)
        {

            var book= await bookRepository.GetBookByName(Id);

            if(book is null)
            {

                return await exceptions.BookNotFound();

            }

            else if(book.Author is null)
            {

                return await exceptions.AuthorNotFound();

            }

            else
            {

                return book;

            }

        }

        public async Task<Book> RemoveBookService(Guid Id)
        {

            var book =await bookRepository.GetBookByName(Id);

            if (book is null)
            {

                return await exceptions.BookNotFound();

            }

            else if (book.Author is null)
            {

                return await exceptions.AuthorNotFound();

            }
            else
            {
                var result = await bookRepository.RemoveBook(Id);

                if(result is null)
                {

                    return await exceptions.BookRemoved();
                }

                return await exceptions.ErrorRemovingBook();

            }
        }
    }
}
