using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Concrete;

namespace Bookstore.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
    }
}
