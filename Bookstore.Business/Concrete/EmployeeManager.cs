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
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public void Add(Employee employee)
        {
            _employeeDal.Add(employee);
        }

        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }
    }
}
