using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IFood
    {
        List<FoodDTO> GetAll();
        void add(FoodDTO food);
        void delete(FoodDTO food);
        void update(FoodDTO f1, FoodDTO f2);
    }
}
