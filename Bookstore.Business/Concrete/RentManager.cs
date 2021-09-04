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
    public class RentManager : IRentService
    {
        private IRentDal _rentDal;
        public RentManager(IRentDal rentDal)
        {
            _rentDal = rentDal;
        }
        public List<Rent> GetAll()
        {
            return _rentDal.GetAll();
        }

        public void Add(Rent rent)
        {
            _rentDal.Add(rent);
        }

        public void Update(Rent rent)
        {
            _rentDal.Update(rent);
        }

        public void Delete(Rent rent)
        {
            _rentDal.Delete(rent);
        }
    }
}
