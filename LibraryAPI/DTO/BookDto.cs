using Library.Core.Domain.Artists;

namespace LibraryAPI.DTO
{
    public class BookDto
    {
        #region Properties
        public string Title { get; set; } = string.Empty;

        public List<ArtistDto> Artists { get; set; } = null!;

        #endregion

        #region constructor
        public BookDto()
        {
        }
        #endregion

    }
}
