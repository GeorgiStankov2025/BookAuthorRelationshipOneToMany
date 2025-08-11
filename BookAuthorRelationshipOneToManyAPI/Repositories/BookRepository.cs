using BookAuthorRelationshipOneToManyAPI.Data;
using BookAuthorRelationshipOneToManyAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookAuthorRelationshipOneToManyAPI.Exceptions;
using System.Linq;

namespace BookAuthorRelationshipOneToManyAPI.Repositories
{
    public class BookRepository(BookAuthorDbContext context, IExceptionList exceptions) : IBookRepository
    {
        public async Task<Book> CreateBook(Book book)
        {

           await context.Books.AddAsync(book);

           await context.SaveChangesAsync();

           return book;

        }

        public async Task<List<Book>> GetAllBooks()
        {
           
            return await context.Books.Include(b=>b.Author).ToListAsync();

        }

        public async Task<Book> GetBookByName(Guid Id)
        {

           var book= await context.Books.Include(i => i.Author)
            .FirstOrDefaultAsync(b => b.Id == Id);

            return book;

        }

        public async Task<Book> RemoveBook(Guid Id)
        {
            
            var book= await GetBookByName(Id);

            context.Books.Remove(book);

            await context.SaveChangesAsync();

            return null;

        }

    }
}
