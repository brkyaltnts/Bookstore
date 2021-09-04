using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.DataAccess.Abstract;
using Bookstore.Entities.Concrete;

namespace Bookstore.DataAccess.Concrete.EntityFramework
{
    public class EfReaderDal : EfEntityRepositoryBase<Reader, BookstoreContext>, IReaderDal
    {
    }
}
