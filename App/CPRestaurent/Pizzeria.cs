using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.ProductBase;

namespace App.ConcreteProducts
{
    public class Pizzeria : Restaurent

    {
        public Pizzeria()
        {
            Name = "Pizzeria";
            Location = "Antelias";
            Specialty = "Pizza";
            rating = 7;

        }

        public override string ShowInfo()
        {
            return ("Name: " + Name + Environment.NewLine + "Location: " + Location + Environment.NewLine + "Specialty: " + Specialty + Environment.NewLine + "rating: " + rating + "/10");

        }





    }
}
