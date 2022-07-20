using Library.Core.Domain.Artists;

namespace Library.Core.Domain.Books
{
    /// <summary>
    /// Modélisation of Book
    /// </summary>
    public class Book
    {
        #region Properties

        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public List<Artist> Artists { get; set; } = null!;
        #endregion
    }
}