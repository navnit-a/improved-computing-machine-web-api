using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Licenses.DataAccess;
using NextGen.API.Models;

namespace NextGen.API.Controllers
{
    public class EmployeesController : BaseController
    {
        public EmployeesController() : base()
        {
        }

        //public IEnumerable<Employee> Get()
        //{
        //    using (var entities = new LicensesEntities())
        //    {
        //        return entities.Employees.ToList();
        //    }
        //}

        //public IEnumerable<object> Get()
        //{

        //    using (var entities = new LicensesEntities())
        //    {
        //        return entities.LicenseKeys.ToList().
        //            Select(f => new
        //                {
        //                    Something = f.LicenseKey1,
        //                    LicenseName = f.LicenseType.LicenseKeys.ToList()
        //                }
        //            );
        //    }
        //}

        public IEnumerable<EmployeeModel> Get()
        {
            using (var entities = new LicensesEntities())
            {
                var result = entities.Employees
                    .ToList()
                    .Select(l => TheModelFactory.Create(l));
                return result;
            }
        }

        public EmployeeModel Get(int colourid)
        {
            using (var entities = new LicensesEntities())
            {
                var result = entities.Employees
                    .ToList()
                    .Select(l => TheModelFactory.Create(l)).FirstOrDefault(c => c.ColourId == colourid);

                return result;
            }
        }
    }
}