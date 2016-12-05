using System.Collections.Generic;
using NextGen.API.Contracts;

namespace NextGen.API.Models
{
    public class FoodRepo : IFood
    {
        public IList<Food> GetFoods()
        {
            return new List<Food>
            {
                new Food {Name = "Pasta", Calorie = "800"},
                new Food {Name = "McDonals", Calorie = "1200"},
                new Food {Name = "Salad", Calorie = "200"}
            };
        }
    }
}