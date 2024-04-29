using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.CSandwich
{
    
        public abstract class Sandwich
        {
            public abstract string GetDescription();

            public abstract double GetPrice();

            public string Description { get; set; }

        }
    
}
