using System.Net.Http;
using System.Web.Http.Routing;
using Licenses.DataAccess;

namespace NextGen.API.Models
{
    public class ModelFactory
    {
        private UrlHelper _urlHelper;

        public ModelFactory(HttpRequestMessage request)
        {
            _urlHelper = new UrlHelper(request);
        }

        public EmployeeModel Create(Employee employee)
        {
            return new EmployeeModel
            {
                Url = _urlHelper.Link("Employee", new { colourid = employee.ColourID}),
                Name = employee.Name,
                ColourId = employee.ColourID
            };
        }
    }
}