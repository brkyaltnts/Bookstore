using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Concrete;
using Type = Bookstore.Entities.Concrete.Type;

namespace Bookstore.Business.Abstract
{
    public interface ITypeService
    {
        List<Type> GetAll();
        void Add(Type type);
        void Update(Type type);
        void Delete(Type type);
    }
}
