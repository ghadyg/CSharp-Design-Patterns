using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.AbstractProduct;

namespace App.CPFood
{
    class BledorSaltM : Menu
    {
        public BledorSaltM()
        {
            Food CheesyTurkey = new Food("Cheesy Turkey", 2);
            CheesyTurkey.ingredient.Add("turkey");
            CheesyTurkey.ingredient.Add("cheese");
            
          
            foods.Add(CheesyTurkey);

            Food HotdognEggs = new Food("Hotdog and Eggs", 5);
            HotdognEggs.ingredient.Add("Hotdog");
            HotdognEggs.ingredient.Add("cheese");
            HotdognEggs.ingredient.Add("Eggs");
            foods.Add(HotdognEggs);
           
            



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
        
    

