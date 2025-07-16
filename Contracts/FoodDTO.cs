using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class FoodDTO
    {
        public static int counter = 0;

        public int id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }

        public FoodDTO(String name, double price, string category)
        {
            this.id = counter++;
            this.Name = name;
            this.Price = price;
            this.Category = category;


        }
        public FoodDTO() { }

    }
}

