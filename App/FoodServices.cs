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
    public class FoodServices : IFood
    {
        public List<Food> _foodList = new List<Food>();


        public List<FoodDTO> GetAll()
        {
            return _foodList
                .Where(f => !f.isDeleted)
                .Select(f => new FoodDTO { id = f.Id, Name = f.Name, Price = f.Price, Category = f.Category })
                .ToList();
        }

        public void add(FoodDTO food)
        {
            if (_foodList.Any(x => x.Name.Equals(food.Name)))
            {
                Console.WriteLine($" Food {food.Name} is already exist ");
            }
            Food food1 = new Food(food.Name, false, food.Price, food.Category, false);
            this._foodList.Add(food1);
            Console.WriteLine($" Food {food.Name} added sucessfully ");


        }

        public void delete(FoodDTO food)
        {
            Food food1 = _foodList.FirstOrDefault(x =>
                !x.isDeleted &&
                (x.Id == food.id || (
                    x.Name.Equals(food.Name) &&
                    x.Price == food.Price &&
                    x.Category.Equals(food.Category)
                )));

            if (food1 != null)
            {
                food1.isDeleted = true;
                Console.WriteLine($"Food '{food1.Name}' removed successfully.");
            }
            else
            {
                Console.WriteLine($"Food '{food.Name}' does not exist or is already deleted.");
            }
        }

        public void update(FoodDTO foodNew, FoodDTO foodOld)
        {

            Food food1 = _foodList.FirstOrDefault(x => x.Name == foodOld.Name);

            if (food1 != null && !food1.isDeleted)
            {
                food1.Name = foodNew.Name;
                food1.Price = foodNew.Price;
                food1.Category = foodNew.Category;
                food1.isUpdated = true;

                Console.WriteLine($"Food with ID {food1.Id} updated successfully.");
            }
            else
            {
                Console.WriteLine($"Food with ID {foodOld.id} does not exist or is deleted.");
            }
        }

    }
}
