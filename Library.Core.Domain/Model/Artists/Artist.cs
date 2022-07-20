using Library.Core.Domain.Books;

namespace Library.Core.Domain.Artists
{
    public class Artist
    {
        #region Properties
        public int Id { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public List<Book> Books { get; set; } = null!;

        #endregion
    }
}