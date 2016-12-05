using System.Collections.Generic;
using NextGen.API.Models;

namespace NextGen.API.Contracts
{
    public interface IFood
    {
        IList<Food> GetFoods();
    }
}
