using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Concrete;

namespace Bookstore.Business.Abstract
{
    public interface IReaderService
    {
        List<Reader> GetAll();
        Reader GetReader(int id);
        void Add(Reader reader);
        void Update(Reader reader);
        void Delete(Reader reader);
    }
}
