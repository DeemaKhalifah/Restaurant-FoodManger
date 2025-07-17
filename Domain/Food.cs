using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Food
    {
        public static int Counter = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }


        public Food(string name, double price, string category)
        {
            Id = Counter++;
            Name = name;
            Price = price;
            Category = category;
            IsDeleted = false;
        }
    }


}
