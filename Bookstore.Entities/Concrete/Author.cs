using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Abstract;

namespace Bookstore.Entities.Concrete
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Biography { get; set; }
    }
}
