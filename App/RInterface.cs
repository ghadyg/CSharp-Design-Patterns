using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.FactoryBase;
using App.ProductBase;
using System.Reflection;
using System.Media;

namespace App
{
    public partial class RInterface : Form
    {
        public RInterface()
        {
            InitializeComponent();
            resto1();
            resto2();
            resto3();
            resto4();
            
        }
     
            

       

        static IRestaurentFactory GetRestaurent(string RestaurentName)
        {
            return Assembly.GetExecutingAssembly().CreateInstance(RestaurentName) as IRestaurentFactory;
        }
        public void resto1()
        {
            //IRestaurentFactory factory = GetRestaurent("App.ConcreteFactories.RestaurentBurger");
            IRestaurentFactory factory = new ConcreteFactories.RestaurentBurger();
            var MiniB = factory.CreateRestaurent();
            MiniBBox.Text = MiniB.ShowInfo();
        }
        public void resto2()
        {
            IRestaurentFactory factory = GetRestaurent("App.ConcreteFactories.RestaurentPizza");

            var Pizzeria = factory.CreateRestaurent();
            PizzeriaBox.Text = Pizzeria.ShowInfo();
        }
        public void resto3()
        {
            IRestaurentFactory factory = GetRestaurent("App.ConcreteFactories.RestaurentDessert");

            var Bledor = factory.CreateRestaurent();
            BledorBox.Text = Bledor.ShowInfo();
        }
        public void resto4()
        {
            IRestaurentFactory factory = GetRestaurent("App.ConcreteFactories.RestaurentSub");

            var Subway = factory.CreateRestaurent();
            subwaybox.Text = Subway.ShowInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiniBForm form = new MiniBForm();
            form.Show();
            Hide();


        }

        private void SubwayMenu_Click(object sender, EventArgs e)
        {
            SubwayForm form = new SubwayForm();
            form.Show();
            Hide();

        }

        private void PizzeriaMenu_Click(object sender, EventArgs e)
        {
            PizzeriaForm form = new PizzeriaForm();
            form.Show();
            Hide();
        }

        private void BledorMenu_Click(object sender, EventArgs e)
        {
            BledorForm form = new BledorForm();
            form.Show();
            Hide();
        }
    }
}
