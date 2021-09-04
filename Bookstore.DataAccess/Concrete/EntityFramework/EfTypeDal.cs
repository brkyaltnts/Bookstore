using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.DataAccess.Abstract;
using Type = Bookstore.Entities.Concrete.Type;

namespace Bookstore.DataAccess.Concrete.EntityFramework
{
    public class EfTypeDal : EfEntityRepositoryBase<Type, BookstoreContext>, ITypeDal
    {
    }
}
