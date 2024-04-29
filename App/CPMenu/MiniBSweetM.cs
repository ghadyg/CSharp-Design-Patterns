using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.AbstractProduct;

namespace App.CPFood
{
    class MiniBSweetM : Menu
    {
        public MiniBSweetM()
        {
            Food ChocoBurger = new Food("Choco burger", 4);
            ChocoBurger.ingredient.Add("nutella");
            ChocoBurger.ingredient.Add("banana");
          
            foods.Add(ChocoBurger);
            
            }

        public override double CheckPrice(string name)
        {
            foreach (var item in foods)
            {
                if (name == item.Name)
                    return item.Price;
            }
            return 0;
        }

        public override string showItems()
        {
            var y = "";
            foreach (var item in foods)
            {
                y += "Name: " + item.Name + Environment.NewLine + "Ingredient: " + item.showingredient() + Environment.NewLine;

            }
            return y;
        }
    }
    }

