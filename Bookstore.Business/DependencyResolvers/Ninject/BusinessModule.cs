using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Business.Abstract;
using Bookstore.Business.Concrete;
using Bookstore.DataAccess.Abstract;
using Bookstore.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Bookstore.Business.DependencyResolvers.Ninject
{
    public class BusinessModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IAuthorService>().To<AuthorManager>();
            Bind<IAuthorDal>().To<EfAuthorDal>();

            Bind<IBookService>().To<BookManager>();
            Bind<IBookDal>().To<EfBookDal>();

            Bind<IEmployeeService>().To<EmployeeManager>();
            Bind<IEmployeeDal>().To<EfEmployeeDal>();

            Bind<ILateDeliveryService>().To<LateDeliveryManager>();
            Bind<ILateDeliveryDal>().To<EfLateDeliveryDal>();

            Bind<IPublisherService>().To<PublisherManager>();
            Bind<IPublisherDal>().To<EfPublisherDal>();

            Bind<IReaderService>().To<ReaderManager>();
            Bind<IReaderDal>().To<EfReaderDal>();

            Bind<IRentService>().To<RentManager>();
            Bind<IRentDal>().To<EfRentDal>();

            Bind<ISaleService>().To<SaleManager>();
            Bind<ISaleDal>().To<EfSaleDal>();

            Bind<ITypeService>().To<TypeManager>();
            Bind<ITypeDal>().To<EfTypeDal>();
        }
    }
}
