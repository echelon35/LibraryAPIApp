using Library.Core.Domain.Books;

namespace LibraryAPI.DTO
{
    public class ArtistDto
    {
        #region Properties
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;

        public List<Book>? Books { get; set; }

        #endregion

        #region constructor
        public ArtistDto()
        {
        }
        #endregion
    }
}
