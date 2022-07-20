using Library.Core.Db.BookConfiguration;
using Library.Core.Db.EntityTypeConfiguration;
using Library.Core.Domain.Artists;
using Library.Core.Domain.Books;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Library.Core.Db
{
    public class LibraryContext : DbContext
    {
        #region Properties
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Artist> Artists { get; set; } = null!;
        #endregion

        /// <summary>
        /// Constructor with db options
        /// </summary>
        /// <param name="dbOptions"></param>
        public LibraryContext([NotNullAttribute] DbContextOptions<LibraryContext> dbOptions) : base(dbOptions)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public LibraryContext() : base()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BookEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistEntityTypeConfiguration());
        }

    }
}