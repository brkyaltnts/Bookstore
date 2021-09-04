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
    public class LateDeliveryManager: ILateDeliveryService
    {
        private ILateDeliveryDal _lateDeliveryDal;
        public LateDeliveryManager(ILateDeliveryDal lateDeliveryDal)
        {
            _lateDeliveryDal = lateDeliveryDal;
        }
        public List<LateDelivery> GetAll()
        {
            return _lateDeliveryDal.GetAll();
        }

        public void Add(LateDelivery lateDelivery)
        {
            _lateDeliveryDal.Add(lateDelivery);
        }

        public void Update(LateDelivery lateDelivery)
        {
            _lateDeliveryDal.Update(lateDelivery);
        }

        public void Delete(LateDelivery lateDelivery)
        {
            _lateDeliveryDal.Delete(lateDelivery);
        }
    }
}
