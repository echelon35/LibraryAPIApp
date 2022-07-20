using Library.Core.Domain.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Domain.DAO
{
    public interface IBookRepository
    {
        IReadOnlyCollection<Book> GetAll();

    }
}
