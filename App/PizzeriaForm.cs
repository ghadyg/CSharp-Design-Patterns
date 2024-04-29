using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using App.AbstarctFactory;
using App.CFMenu;

namespace App
{
    public partial class PizzeriaForm : Form
    {
        public PizzeriaForm()
        {
            InitializeComponent();
            menu();
        }
       
        public void menu()
        {


            IMenuFactory Pizzeria = new PizzeriaMenu();
            PizzeriaMenuBox.Text = Pizzeria.CreateSaltyFood().showItems();
            PizzeriaMenuBox.Text += Pizzeria.CreateSweetFood().showItems();

            PPPrice.Text = Convert.ToString(Pizzeria.CreateSaltyFood().CheckPrice("Pepperoni Pizza"));
                BPPrice.Text = Convert.ToString(Pizzeria.CreateSaltyFood().CheckPrice("Barbecue Pizza"));
                SPPrice.Text = Convert.ToString(Pizzeria.CreateSaltyFood().CheckPrice("Soujouk Pizza"));
                LPPrice.Text = Convert.ToString(Pizzeria.CreateSaltyFood().CheckPrice("Lebanese Pizza"));
                ChPPrice.Text = Convert.ToString(Pizzeria.CreateSweetFood().CheckPrice("Choco Pizza"));

            
        }

        private void Pricebtn_Click(object sender, EventArgs e)
        {
            try
            {
                undobtn.Visible = true;
                Order.Visible = true;
                quantitybox.Enabled = false;
                TPTxt.Text = Convert.ToString(Convert.ToDouble(PPPrice.Text) * Convert.ToDouble(PPquantity.Text) + Convert.ToDouble(BPPrice.Text) * Convert.ToDouble(BPquantity.Text) + Convert.ToDouble(SPPrice.Text) * Convert.ToDouble(SPquantity.Text) + Convert.ToDouble(LPPrice.Text) * Convert.ToDouble(LPquantity.Text) + Convert.ToDouble(ChPPrice.Text) * Convert.ToDouble(ChPquantity.Text));
            }
            catch
            {
                MessageBox.Show("make sure you put numbers inside quantity box");
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            RInterface form = new RInterface();
            form.Show();
            Close();
        }

        private void undobtn_Click(object sender, EventArgs e)
        {
            PPquantity.Text = "0";
            SPquantity.Text = "0";
            BPquantity.Text = "0";
            ChPquantity.Text = "0";
            LPquantity.Text = "0";
            TPTxt.Text = "0";
            quantitybox.Enabled = true;
            undobtn.Visible = false;
            Order.Visible = false;
        }

        private void Order_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm();
            form.Show();
            Close();
        }
    }
}
