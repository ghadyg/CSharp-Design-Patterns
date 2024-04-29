using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.ConcreteProducts;
using App.FactoryBase;
using App.ProductBase;

namespace App.ConcreteFactories
{
    public class RestaurentSub:IRestaurentFactory    
    {
        public Restaurent CreateRestaurent()
        {
            return new Subway();
        }
    }
}
