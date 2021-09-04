using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Concrete;

namespace Bookstore.DataAccess.Abstract
{
    public interface IBookDal : IEntityRepository<Book>
    {
    }
}
