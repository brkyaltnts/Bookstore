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
    public class AuthorManager : IAuthorService
    {
        private IAuthorDal _authorDal;
        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }
        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }

        public void Delete(Author author)
        {
            _authorDal.Delete(author);
        }
    }
}
