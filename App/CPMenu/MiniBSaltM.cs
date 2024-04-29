using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.AbstractProduct;

namespace App.CPFood
{
    class MiniBSaltM : Menu
    {
        public MiniBSaltM()
        {
            Food CrispyBurger = new Food("Crispy burger", 6.5);
            CrispyBurger.ingredient.Add("chicken");
            CrispyBurger.ingredient.Add("sauce");
            CrispyBurger.ingredient.Add("cheddar");
            CrispyBurger.ingredient.Add("lettuce");
            foods.Add(CrispyBurger);

            Food MushroomBurger = new Food("Mushroom burger", 8);
            MushroomBurger.ingredient.Add("beef");
            MushroomBurger.ingredient.Add("sauce");
            MushroomBurger.ingredient.Add("mushroom");
            MushroomBurger.ingredient.Add("Swiss cheese");
            foods.Add(MushroomBurger);

            Food BaconBurger = new Food("Bacon burger", 7);
            BaconBurger.ingredient.Add("Beef");
            BaconBurger.ingredient.Add("Bacon");
            BaconBurger.ingredient.Add("sauce");
            BaconBurger.ingredient.Add("tomato");
            foods.Add(BaconBurger);

            Food Lebaneseburger = new Food("Lebanese burger", 5);
            Lebaneseburger.ingredient.Add("chicken");
            Lebaneseburger.ingredient.Add("sauce");
            Lebaneseburger.ingredient.Add("coleslaw");
            Lebaneseburger.ingredient.Add("fries");
            foods.Add(Lebaneseburger);



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
        
    

