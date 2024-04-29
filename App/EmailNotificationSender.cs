using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.NotificatonBaseSender;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace App
{
    public class EmailNotificationSender : NotificationSenderBase
    {
        public EmailNotificationSender(Person person) : base(person)
        {
        }

        protected override string GetNotificationText()
        {
            return "An email has been send to you";
        }
        public override void notify()
        {
            MessageBox.Show(GetNotificationText());


            Thread.Sleep(2000);
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Ghadi\source\repos\App\App\Resources\samsung_letter.wav");
            simpleSound.Play();
            MessageBox.Show("you have a new Email");



        }
    }
}


