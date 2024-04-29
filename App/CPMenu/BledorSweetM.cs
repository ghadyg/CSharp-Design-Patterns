using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.AbstractProduct;

namespace App.CPFood
{
    class BledorSweetM : Menu
    {
        public BledorSweetM()
        {
            Food Crepe = new Food("Crepe", 5);
            Crepe.ingredient.Add("oreo");
            Crepe.ingredient.Add("lotus");
            Crepe.ingredient.Add("white chocolate");
          
            foods.Add(Crepe);

            Food waffle = new Food("Waffle", 3);
            waffle.ingredient.Add("chocolate");
            waffle.ingredient.Add("sirup");
            waffle.ingredient.Add("strawberry");
            
            foods.Add(waffle);

            Food Fondant = new Food("Fondant", 6);
            Fondant.ingredient.Add("chocolate cake");
            Fondant.ingredient.Add("sirup");
            Fondant.ingredient.Add("ice cream");
           
            foods.Add(Fondant);

            



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
                y += "Name: " + item.Name + Environment.NewLine + "Ingredient: " + item.showingredient() + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            }
            return y;
        }
    }
}
        
    

