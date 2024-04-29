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
    public partial class MiniBForm : Form
    {
        public MiniBForm()
        {
            InitializeComponent();
            menu();
            
        }
        

        public void menu()
        {


            IMenuFactory MiniB = new MiniBMenu();
           MiniBMenuBox.Text= MiniB.CreateSaltyFood().showItems();
            MiniBMenuBox.Text += MiniB.CreateSweetFood().showItems();
                
               CBPrice.Text = Convert.ToString(MiniB.CreateSaltyFood().CheckPrice("Crispy burger"));
                MBPrice.Text = Convert.ToString(MiniB.CreateSaltyFood().CheckPrice("Mushroom burger"));
                BBPrice.Text = Convert.ToString(MiniB.CreateSaltyFood().CheckPrice("Bacon burger"));
                LBPrice.Text = Convert.ToString(MiniB.CreateSaltyFood().CheckPrice("Lebanese burger"));
                ChBPrice.Text = Convert.ToString(MiniB.CreateSweetFood().CheckPrice("Choco burger"));

            
        }

        private void Pricebtn_Click(object sender, EventArgs e)
        {
            try
            {
                undobtn.Visible = true;
                Order.Visible = true;
                quantitybox.Enabled = false;
                TPTxt.Text = Convert.ToString(Convert.ToDouble(CBPrice.Text) * Convert.ToDouble(CBquantity.Text) + Convert.ToDouble(MBPrice.Text) * Convert.ToDouble(MBquantity.Text) + Convert.ToDouble(BBPrice.Text) * Convert.ToDouble(BBquantity.Text) + Convert.ToDouble(LBPrice.Text) * Convert.ToDouble(LBquantity.Text) + Convert.ToDouble(ChBPrice.Text) * Convert.ToDouble(ChBquantity.Text));
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
            CBquantity.Text = "0";
            MBquantity.Text = "0";
            BBquantity.Text = "0";
            ChBquantity.Text = "0";
            LBquantity.Text = "0";
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
