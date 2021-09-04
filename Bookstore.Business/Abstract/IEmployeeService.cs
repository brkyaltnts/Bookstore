using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Entities.Concrete;

namespace Bookstore.Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
    }
}
