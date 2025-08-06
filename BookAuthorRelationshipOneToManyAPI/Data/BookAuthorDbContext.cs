using BookAuthorRelationshipOneToManyAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookAuthorRelationshipOneToManyAPI.Data
{
    public class BookAuthorDbContext(DbContextOptions<BookAuthorDbContext> options):DbContext(options)
    {

        public DbSet<Book> Books => Set<Book>();
        public DbSet<Author> Authors => Set<Author>();

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .HasOne(a => a.Author)
                .WithMany(b => b.Books)
                .HasForeignKey(a=>a.AuthorId);

            
        }

    }
}
