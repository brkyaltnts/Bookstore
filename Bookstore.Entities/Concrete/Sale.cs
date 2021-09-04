using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Abstract;

namespace Bookstore.Entities.Concrete
{
    public class Sale : IEntity
    {
        public int Id{ get; set; }
        public int BookId{ get; set; }
        public int ReaderId{ get; set; }
        public int PersonId{ get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string Phone{ get; set; }
        public string Email{ get; set; }
        public DateTime SellDate{ get; set; }
        public decimal Price{ get; set; }
        public decimal PointsEarned{ get; set; }
    }
}
