using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Concrete;

namespace Bookstore.Business.Abstract
{
    public interface IRentService
    {
        List<Rent> GetAll();
        void Add(Rent rent);
        void Update(Rent rent);
        void Delete(Rent rent);
    }
}
