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
    public class ReaderManager : IReaderService
    {
        private IReaderDal _readerDal;
        public ReaderManager(IReaderDal readerDal)
        {
            _readerDal = readerDal;
        }
        public List<Reader> GetAll()
        {
            return _readerDal.GetAll();
        }

        public Reader GetReader(int id)
        {
            return _readerDal.GetAll().FirstOrDefault(x => x.Id == id);
        }

        public void Add(Reader reader)
        {
            _readerDal.Add(reader);
        }

        public void Update(Reader reader)
        {
            _readerDal.Update(reader);
        }

        public void Delete(Reader reader)
        {
            _readerDal.Delete(reader);
        }
    }
}
