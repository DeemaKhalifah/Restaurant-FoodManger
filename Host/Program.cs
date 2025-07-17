using System;
using System.Collections.Generic;
using Contracts;    
using App;          

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFoodServices foodService = new FoodServices();

            foodService.Add(new FoodDTO("Pizza", 60.00, "Junk Food"));
            foodService.Add(new FoodDTO("Burger", 40.00, "Junk Food"));
            foodService.Add(new FoodDTO("Pasta", 30.00, "Junk Food"));

            Console.WriteLine("------ Food List ------");
            PrintList(foodService.GetAll());

            Console.WriteLine("------ Delete Burger ------");
            foodService.Delete(2); 
            PrintList(foodService.GetAll());

            Console.WriteLine("------ Update Pasta ------");
            foodService.Update(3, new FoodDTO("Updated Pasta", 35.00, "Healthy"));
            PrintList(foodService.GetAll());

            Console.ReadKey();
        }

        static void PrintList(List<FoodDTO> foods)
        {
            foreach (var food in foods)
            {
                Console.WriteLine($"ID: {food.Id}, Name: {food.Name}, Price: {food.Price}, Category: {food.Category}");
            }
            Console.WriteLine("--------------------------");
        }
    }
}
