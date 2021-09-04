using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Abstract;

namespace Bookstore.Entities.Concrete
{
    public class Rent : IEntity
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int ReaderId { get; set; }
        public int PersonId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string LatestEvent { get; set; }
        public decimal PointsEarned { get; set; }
    }
}
