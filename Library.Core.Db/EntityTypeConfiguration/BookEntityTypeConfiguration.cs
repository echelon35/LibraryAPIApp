using Library.Core.Domain.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Db.BookConfiguration
{
    /// <summary>
    /// Configure objects on SQL Server corresponding to [Book]
    /// </summary>
    class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
    {


        #region Public methods
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            //Table creation
            builder.ToTable("Book");

            //Primary key
            builder.HasKey(x => x.Id);

            //MANY [BOOKS] are written by MANY [CREATORS]
            builder.HasMany(x => x.Artists).WithMany(x => x.Books);
        }
        #endregion
    }
}
