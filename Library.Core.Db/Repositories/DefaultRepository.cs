using Library.Core.Domain.Books;
using Library.Core.Domain.DAO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Db.Repositories
{
    public class DefaultRepository : IBookRepository
    {
        private readonly LibraryContext _context = null!;

        public DefaultRepository(LibraryContext context)
        {
            _context = context;
        }

        public IReadOnlyCollection<Book> GetAll()
        {
            return _context.Books.Include(item => item.Artists).ToList();
        }
    }
}
