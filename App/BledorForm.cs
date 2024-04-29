using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.AbstarctFactory;
using App.CFMenu;

namespace App
{
    public partial class BledorForm : Form
    {
        public BledorForm()
        {
            InitializeComponent();
            menu();
        }
        public void menu()
        {


            IMenuFactory Bledor = new BledorMenu();
            BledorMenuBox.Text = Bledor.CreateSaltyFood().showItems();
            BledorMenuBox.Text += Bledor.CreateSweetFood().showItems();

            CTPrice.Text = Convert.ToString(Bledor.CreateSaltyFood().CheckPrice("Cheesy Turkey"));
            HEPrice.Text = Convert.ToString(Bledor.CreateSaltyFood().CheckPrice("Hotdog and Eggs"));
            CPrice.Text = Convert.ToString(Bledor.CreateSweetFood().CheckPrice("Crepe"));
            WPrice.Text = Convert.ToString(Bledor.CreateSweetFood().CheckPrice("Waffle"));
            FPrice.Text = Convert.ToString(Bledor.CreateSweetFood().CheckPrice("Fondant"));


        }

        private void Pricebtn_Click(object sender, EventArgs e)
        {
            try
            {
                undobtn.Visible = true;
                Order.Visible = true;
                quantitybox.Enabled = false;
                TPTxt.Text = Convert.ToString(Convert.ToDouble(CTPrice.Text) * Convert.ToDouble(CTquantity.Text) + Convert.ToDouble(HEPrice.Text) * Convert.ToDouble(HEquantity.Text) + Convert.ToDouble(CPrice.Text) * Convert.ToDouble(Cquantity.Text) + Convert.ToDouble(WPrice.Text) * Convert.ToDouble(Wquantity.Text) + Convert.ToDouble(FPrice.Text) * Convert.ToDouble(Fquantity.Text));
            }
            catch
            {
                MessageBox.Show("make sure you put numbers inside quantity box");
            }
        }

        private void undobtn_Click(object sender, EventArgs e)
        {
            HEquantity.Text = "0";
            Wquantity.Text = "0";
            Cquantity.Text = "0";
            CTquantity.Text = "0";
            Fquantity.Text = "0";
            TPTxt.Text = "0";
            quantitybox.Enabled = true;
            undobtn.Visible = false;
            Order.Visible = false;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            RInterface form = new RInterface();
            form.Show();
            Close();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            OrderForm form = new OrderForm();
            form.Show();
            Close();
        }
    }
}
