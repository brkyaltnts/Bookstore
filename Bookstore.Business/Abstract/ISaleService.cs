using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Concrete;

namespace Bookstore.Business.Abstract
{
    public interface ISaleService
    {
        List<Sale> GetAll();
        void Add(Sale sale);
        void Update(Sale sale);
        void Delete(Sale sale);
    }
}
