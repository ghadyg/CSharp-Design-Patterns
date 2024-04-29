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
    class MiniBMenu : IMenuFactory
    {
        public Menu CreateSaltyFood()
        {
            return new MiniBSaltM();
        }

        public Menu CreateSweetFood()
        {
            return new MiniBSweetM();
        }
    }
}
