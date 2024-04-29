using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.AbstractProduct;

namespace App.CPFood
{
    class PizzeriaSaltM : Menu
    {
        public PizzeriaSaltM()
        {
            Food PepperoniPizza = new Food("Pepperoni Pizza", 7);
            PepperoniPizza.ingredient.Add("Pepperoni");
            PepperoniPizza.ingredient.Add("cheese");
            PepperoniPizza.ingredient.Add("mushroom");
            PepperoniPizza.ingredient.Add("sauce");
            foods.Add(PepperoniPizza);

            Food BarbecuePizza = new Food("Barbecue Pizza", 9);
            BarbecuePizza.ingredient.Add("chicken");
            BarbecuePizza.ingredient.Add("barbecue");
            BarbecuePizza.ingredient.Add("mushroom");
            BarbecuePizza.ingredient.Add("cheese");
            foods.Add(BarbecuePizza);

            Food SoujoukPizza = new Food("Soujouk Pizza", 8);
            SoujoukPizza.ingredient.Add("Soujouk");
            SoujoukPizza.ingredient.Add("cheese");
            SoujoukPizza.ingredient.Add("mushroom");
            SoujoukPizza.ingredient.Add("sauce");
            foods.Add(SoujoukPizza);

            Food LebanesePizza = new Food("Lebanese Pizza", 5);
            LebanesePizza.ingredient.Add("cheese");
            LebanesePizza.ingredient.Add("sauce");
            LebanesePizza.ingredient.Add("turkey");
            LebanesePizza.ingredient.Add("olive");
            LebanesePizza.ingredient.Add("mushroom");
            foods.Add(LebanesePizza);



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
        
    

