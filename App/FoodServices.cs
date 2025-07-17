using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Domain;
using Contracts;

namespace App
{
    public class FoodServices : IFoodServices
    {
        private List<Food> _foodList = new List<Food>();

        public List<FoodDTO> GetAll()
        {
            return _foodList
                .Where(f => !f.IsDeleted)
                .Select(f => new FoodDTO { Id = f.Id, Name = f.Name, Price = f.Price, Category = f.Category })
                .ToList();
        }

        public void Add(FoodDTO food)
        {
            if (food == null)
            {
                Console.WriteLine(" Cannot add null food.");
                return;
            }
            if (_foodList.Any(x => x.Name.Equals(food.Name , StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($" Food {food.Name} is already exist ");
            }
            var food1 = new Food (food.Name,food.Price, food.Category);
            this._foodList.Add(food1);
            Console.WriteLine($" Food {food.Name} added sucessfully ");
        }

        public void Delete(int id)
        {
            var food1 = _foodList.FirstOrDefault(x => !x.IsDeleted && x.Id == id);
            if (food1 != null)
            {
                food1.IsDeleted = true;
                Console.WriteLine($"Food with ID {id} deleted.");
            }
            else
            {
                Console.WriteLine($"Food with ID {id} not found or  already deleted.");
            }
        }

        public void Update(int id, FoodDTO updatedFood)
        {
            if (updatedFood == null)
            {
                Console.WriteLine(" Cannot update with null data");
                return;
            }
            var food = _foodList.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (food != null )
            {
                food.Name = updatedFood.Name;
                food.Price = updatedFood.Price;
                food.Category = updatedFood.Category;

                Console.WriteLine($"Food with ID {id} updated successfully.");
            }
           else
            {
                Console.WriteLine($"Food with ID {id}  not found or deleted.");
            }
        }

    }
}
