using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Abstract;

namespace Bookstore.Entities.Concrete
{
    public class Book : IEntity
    {
        public int Id{ get; set; }
        public int AuthorId{ get; set; }
        public int PublisherId{ get; set; }
        public int TypeId{ get; set; }
        public string ISBN{ get; set; }
        public string BookName{ get; set; }
        public string Edition{ get; set; }
        public string Page{ get; set; }
        public string CoverType{ get; set; }
        public decimal Price{ get; set; }
        public string Summary{ get; set; }
    }
}
