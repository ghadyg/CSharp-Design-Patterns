using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.CSandwich;

namespace App.DSandwich
{
    public class SandwichAddon:Sandwich
    {
        protected Sandwich Sandwich;

        public SandwichAddon(Sandwich sandwich)
        {
            Sandwich = sandwich;
        }

        public override string GetDescription()
        {
            return Sandwich.GetDescription();
        }

        public override double GetPrice()
        {
            return Sandwich.GetPrice();
        }
    }
}
