using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.CSandwich;

namespace App.CCSandwich
{
    class ChickenSandwich:Sandwich
    {
        public ChickenSandwich()
        {
            Description = "Chicken Sandwich";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrice()
        {
            return 3.5;
        }
    }
}
