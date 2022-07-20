using Library.Core.Domain.Artists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Db.EntityTypeConfiguration
{
    public class ArtistEntityTypeConfiguration : IEntityTypeConfiguration<Artist>
    {
        #region Public methods
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            //Table creation
            builder.ToTable("Artist");

            //Primary key
            builder.HasKey(x => x.Id);

            //MANY [BOOKS] are written by MANY [CREATORS]
            builder.HasMany(x => x.Books).WithMany(x => x.Artists);
        }
        #endregion
    }
}
