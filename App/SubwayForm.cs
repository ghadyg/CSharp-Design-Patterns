using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.CSandwich;
using App.CCSandwich;
using App.CDSandwich;

namespace App
{
    public partial class SubwayForm : Form
    {
        public SubwayForm()
        {
            InitializeComponent();
        }

        private void Pricebtn_Click(object sender, EventArgs e)
        {
            if(tunabtn.Checked==true)
            {
                Sandwich thissandwich = new TunaSandwich();
                TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                DescLbl.Text = thissandwich.GetDescription();
                if (Cheesebtn.Checked==true)
                {
                    thissandwich = new Cheese(thissandwich);
                    TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                    DescLbl.Text = thissandwich.GetDescription();

                }
                if (Baconbtn.Checked == true)
                {
                    thissandwich = new bacon(thissandwich);
                    TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                    DescLbl.Text = thissandwich.GetDescription();

                }
                if (Tomatobtn.Checked == true)
                {
                    thissandwich = new tomato(thissandwich);
                    TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                    DescLbl.Text = thissandwich.GetDescription();

                }
                if (Saucebtn.Checked == true)
                {
                    thissandwich = new sauce(thissandwich);
                    TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                    DescLbl.Text = thissandwich.GetDescription();

                }
            }
            if (Beefbtn.Checked == true)
            {
                Sandwich thissandwich = new BeefSandwich();
                TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                DescLbl.Text = thissandwich.GetDescription();
                if (Cheesebtn.Checked == true)
                {
                    thissandwich = new Cheese(thissandwich);
                    TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                    DescLbl.Text = thissandwich.GetDescription();

                }
                if (Baconbtn.Checked == true)
                {
                    thissandwich = new bacon(thissandwich);
                    TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                    DescLbl.Text = thissandwich.GetDescription();

                }
                if (Tomatobtn.Checked == true)
                {
                    thissandwich = new tomato(thissandwich);
                    TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                    DescLbl.Text = thissandwich.GetDescription();

                }
                if (Saucebtn.Checked == true)
                {
                    thissandwich = new sauce(thissandwich);
                    TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                    DescLbl.Text = thissandwich.GetDescription();

                }
            }
            if (Chickenbtn.Checked == true)
            {
                Sandwich thissandwich = new ChickenSandwich();
                TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                DescLbl.Text = thissandwich.GetDescription();
                if (Cheesebtn.Checked == true)
                {
                    thissandwich = new Cheese(thissandwich);
                    TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                    DescLbl.Text = thissandwich.GetDescription();

                }
                if (Baconbtn.Checked == true)
                {
                    thissandwich = new bacon(thissandwich);
                    TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                    DescLbl.Text = thissandwich.GetDescription();

                }
                if (Tomatobtn.Checked == true)
                {
                    thissandwich = new tomato(thissandwich);
                    TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                    DescLbl.Text = thissandwich.GetDescription();

                }
                if (Saucebtn.Checked == true)
                {
                    thissandwich = new sauce(thissandwich);
                    TPBox.Text = Convert.ToString(thissandwich.GetPrice());
                    DescLbl.Text = thissandwich.GetDescription();

                }
              
            }
            mainbox.Enabled = false;
            AddOnBox.Enabled = false;
            undobtn.Visible = true;
            Order.Visible = true;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            RInterface form = new RInterface();
            form.Show();
            Close();
        }

        private void undobtn_Click(object sender, EventArgs e)
        {
            TPBox.Text = "0";
            mainbox.Enabled = true;
            AddOnBox.Enabled = true;
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
