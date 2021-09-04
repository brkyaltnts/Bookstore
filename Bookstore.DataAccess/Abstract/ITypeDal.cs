using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Bookstore.Entities.Concrete.Type;

namespace Bookstore.DataAccess.Abstract
{
    public interface ITypeDal : IEntityRepository<Type>
    {
    }
}
