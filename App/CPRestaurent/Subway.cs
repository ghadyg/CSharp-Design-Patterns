using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.ProductBase;

namespace App.ConcreteProducts
{
    public class Subway:Restaurent

    {
        public Subway()
        {
            Name = "Subway";
            Location = "Hazmieh";
            Specialty = "sandwiches";
            rating = 7.5;

        }
        
        public override string ShowInfo()
        {
            return ("Name: " + Name + Environment.NewLine + "Location: " + Location + Environment.NewLine + "Specialty: " + Specialty + Environment.NewLine + "rating: " + rating + "/10");
        }

      



    }
}
