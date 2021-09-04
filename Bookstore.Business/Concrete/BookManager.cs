using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Business.Abstract;
using Bookstore.DataAccess.Abstract;
using Bookstore.Entities.Concrete;

namespace Bookstore.Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }
        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<Book> GetPriceByBook(int id)
        {
            return _bookDal.GetAll(p => p.Id == id);
        }

        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }
    }
}
