﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.CSandwich;
namespace App.CCSandwich
{
    public class BeefSandwich:Sandwich
    {
        public BeefSandwich()
        {
            Description = "Beef Sandwich";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrice()
        {
            return 5;
        }
    }
}
