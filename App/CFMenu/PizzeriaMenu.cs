using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.AbstarctFactory;
using App.AbstractProduct;
using App.CPFood;

namespace App.CFMenu
{
    class PizzeriaMenu : IMenuFactory
    {
        public Menu CreateSaltyFood()
        {
            return new PizzeriaSaltM();
        }

        public Menu CreateSweetFood()
        {
            return new PizzeriaSweetM();
        }
    }
}
