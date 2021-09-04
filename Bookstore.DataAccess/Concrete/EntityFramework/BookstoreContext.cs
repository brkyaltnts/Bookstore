using Bookstore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = Bookstore.Entities.Concrete.Type;

namespace Bookstore.DataAccess.Concrete.EntityFramework
{
    public class BookstoreContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LateDelivery> LateDeliveries { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Type> Types { get; set; }

    }
}
