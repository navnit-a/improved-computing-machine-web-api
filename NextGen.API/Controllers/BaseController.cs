using System.Web.Http;
using NextGen.API.Models;

namespace NextGen.API.Controllers
{
    public abstract class BaseController : ApiController
    {
        private ModelFactory _modelFactory;

        protected ModelFactory TheModelFactory => _modelFactory ?? (_modelFactory = new ModelFactory(Request));
    }
}