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
    public class SaleManager : ISaleService
    {
        private ISaleDal _saleDal;
        public SaleManager(ISaleDal saleDal)
        {
            _saleDal = saleDal;
        }
        public List<Sale> GetAll()
        {
            return _saleDal.GetAll();
        }

        public void Add(Sale sale)
        {
            _saleDal.Add(sale);
        }

        public void Update(Sale sale)
        {
            _saleDal.Update(sale);
        }

        public void Delete(Sale sale)
        {
            _saleDal.Delete(sale);
        }
    }
}
