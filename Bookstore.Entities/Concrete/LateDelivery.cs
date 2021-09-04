using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Abstract;

namespace Bookstore.Entities.Concrete
{
    public class LateDelivery : IEntity
    {
        public int Id { get; set; }
        public int RentId{ get; set; }
        public DateTime LateDeliveryDate{ get; set; }
        public decimal PenaltyPoints{ get; set; }
        public string Reason{ get; set; }
    }
}
