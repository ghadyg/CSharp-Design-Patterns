using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ProductBase
{
    public abstract class Restaurent
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Specialty { get; set; }
        public double rating { get; set; }
        public abstract string ShowInfo();

    }
}
