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
    public class PublisherManager : IPublisherService
    {
        private IPublisherDal _publisherDal;
        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }
        public List<Publisher> GetAll()
        {
            return _publisherDal.GetAll();
        }

        public void Add(Publisher publisher)
        {
            _publisherDal.Add(publisher);
        }

        public void Update(Publisher publisher)
        {
            _publisherDal.Update(publisher);
        }

        public void Delete(Publisher publisher)
        {
            _publisherDal.Delete(publisher);
        }
    }
}
