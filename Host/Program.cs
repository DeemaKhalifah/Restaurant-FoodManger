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
            IFood foodService = new FoodServices(); 

            foodService.add(new FoodDTO("PIZZA", 60.00, "JUNK FOOD"));
            foodService.add(new FoodDTO("Burger", 40.00, "JUNK FOOD"));
            foodService.add(new FoodDTO("pasta", 30.00, "JUNK FOOD"));
            Console.WriteLine("--------------------------------------");

            List<FoodDTO> list = foodService.GetAll();
            foreach (var x in list)
            {
                Console.WriteLine($"Name: {x.Name}, Price: {x.Price}, Category: {x.Category}, ID: {x.id}");
            }

            Console.WriteLine("--------------------------------------");

            foodService.delete(new FoodDTO("PIZZA", 60.00, "JUNK FOOD"));
            List<FoodDTO> list1 = foodService.GetAll();
            foreach (var x in list1)
            {
                Console.WriteLine($"Name: {x.Name}, Price: {x.Price}, Category: {x.Category}, ID: {x.id}");
            }

            Console.WriteLine("--------------------------------------");

            foodService.update(new FoodDTO("pppp", 30.00, "JUNK FOOD"), new FoodDTO("Burger", 30.00, "JUNK FOOD"));
            List<FoodDTO> list2 = foodService.GetAll();
            foreach (var x in list2)
            {
                Console.WriteLine($"Name: {x.Name}, Price: {x.Price}, Category: {x.Category}, ID: {x.id}");
            }

            Console.WriteLine("--------------------------------------");
            Console.ReadKey();
        }
    }
}