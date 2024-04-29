using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.CSandwich;
using App.DSandwich;

namespace App.CDSandwich
{
    public class sauce: SandwichAddon
    {
        public sauce(Sandwich sandwich) : base(sandwich)
        {
            Description = "sauce";
        }

        public override string GetDescription()
        {
            return Sandwich.GetDescription() + ", " + Description;
        }

        public override double GetPrice()
        {
            return Sandwich.GetPrice() + 0;
        }

    }
}

