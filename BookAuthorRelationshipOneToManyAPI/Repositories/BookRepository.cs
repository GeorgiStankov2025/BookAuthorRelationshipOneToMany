using BookAuthorRelationshipOneToManyAPI.Data;
using BookAuthorRelationshipOneToManyAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookAuthorRelationshipOneToManyAPI.Repositories
{
    public class BookRepository(BookAuthorDbContext context) : IBookRepository
    {
        public async Task<Book> CreateBook(Book book,Author author)
        {
            
           await context.Books.AddAsync(book);

           book.Author = author;

           await context.SaveChangesAsync();

           return book;

        }

        public async Task<List<Book>> GetAllBooks()
        {
            
          return await context.Books.ToListAsync();
            
        }

        public async Task<Book> GetBookByName(string Name)
        {

            var book = await context.Books.FindAsync(Name);

            book.Author = await context.Authors.FindAsync(book.AuthorId);

            return book;

        }

        public async Task<Book> RemoveBook(string name)
        {
            
            var book= await GetBookByName(name);

            context.Books.Remove(book);

            await context.SaveChangesAsync();

            return null;

        }

    }
}
