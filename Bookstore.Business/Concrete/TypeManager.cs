using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Business.Abstract;
using Bookstore.DataAccess.Abstract;
using Type = Bookstore.Entities.Concrete.Type;

namespace Bookstore.Business.Concrete
{
    public class TypeManager : ITypeService
    {
        private ITypeDal _typeDal;
        public TypeManager(ITypeDal typeDal)
        {
            _typeDal = typeDal;
        }
        public List<Type> GetAll()
        {
            return _typeDal.GetAll();
        }

        public void Add(Type type)
        {
            _typeDal.Add(type);
        }

        public void Update(Type type)
        {
            _typeDal.Update(type);
        }

        public void Delete(Type type)
        {
            _typeDal.Delete(type);
        }
    }
}
