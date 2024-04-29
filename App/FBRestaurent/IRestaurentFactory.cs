using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.ProductBase;

namespace App.FactoryBase
{
    public interface IRestaurentFactory
    {
        Restaurent CreateRestaurent();

    }
}
