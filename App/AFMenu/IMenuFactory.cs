using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.AbstractProduct;

namespace App.AbstarctFactory
{
    public interface IMenuFactory
    {
        Menu CreateSweetFood();
        Menu CreateSaltyFood();
      
        


    }
}


