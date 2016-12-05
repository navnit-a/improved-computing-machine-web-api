using System.Collections.Generic;
using System.Web.Http;
using NextGen.API.Contracts;
using NextGen.API.Models;

namespace NextGen.API.Controllers
{
    public class FoodsController : ApiController
    {
        private readonly IFood _foodRepo;
        public FoodsController(IFood foodRepo)
        {
            _foodRepo = foodRepo;
        }
        public IEnumerable<Food> Get()
        {
            return _foodRepo.GetFoods();
        }
    }
}