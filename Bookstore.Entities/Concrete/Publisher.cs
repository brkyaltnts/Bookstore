using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Abstract;

namespace Bookstore.Entities.Concrete
{
    public class Publisher : IEntity
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
    }
}
