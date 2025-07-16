using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Food
    {
        public static int counter = 1;

        public string Name { get; set; }
        public int Id { get; set; }
        public bool isDeleted { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }
        public bool isUpdated { get; set; }


        public Food(string name, bool isDeleted, double price, string category, bool isUpdated)
        {

            this.Name = name;
            this.Id = counter++;
            this.isDeleted = isDeleted;
            this.Price = price;
            this.Category = category;
            this.isUpdated = isUpdated;
        }


    }
}
