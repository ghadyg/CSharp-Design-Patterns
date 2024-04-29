using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
   public  class Food
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public List<string> ingredient = new List<string>();
        public Food(string name,double price)
        {
            Name = name;
            Price = price;
        }
        public string showingredient()
        {
            var y = "";
            foreach (var item in ingredient)
            {
                y += item + ", ";
            }

                return y;
        }

    }
}
