using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.AbstractProduct
{
    public abstract class Menu
    {
        
        
        
        public List<Food> foods = new List<Food>();

        public abstract string showItems();
        public abstract double CheckPrice(string name);

    }
}
