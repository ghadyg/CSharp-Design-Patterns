using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace App
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person(FNameBox.Text, LNBox.Text, EmailBox.Text, Convert.ToInt32(PNBox.Text));
                var message = new Message();
                if (Numberbtn.Checked==true)
                {
                    message.Sender = new MessageNotificationSender(person);
                    message.Send();
                    RInterface form = new RInterface();
                    form.Show();
                    Close();
                }
                
                else if (Mailbtn.Checked == true)
                {
                    message.Sender = new EmailNotificationSender(person);
                    message.Send();
                    RInterface form = new RInterface();
                    form.Show();
                    Close();


                }
                else
                    MessageBox.Show("please choose an option");
            }
            catch
            {
                MessageBox.Show("fill correctly the boxes");
            }
            

        }
    }
}
