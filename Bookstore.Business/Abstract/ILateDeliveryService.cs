using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Concrete;

namespace Bookstore.Business.Abstract
{
    public interface ILateDeliveryService
    {
        List<LateDelivery> GetAll();
        void Add(LateDelivery lateDelivery);
        void Update(LateDelivery lateDelivery);
        void Delete(LateDelivery lateDelivery);
    }
}
