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
    public class MessageNotificationSender : NotificationSenderBase
    {
        public MessageNotificationSender(Person person) : base(person)
        {
        }

        protected override string GetNotificationText()
        {
            return "A Message has been send to you";
        }
        public override void notify()
        {

            MessageBox.Show(GetNotificationText());
            Thread.Sleep(1000);
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Ghadi\source\repos\App\App\Resources\Samsung - Notification Tone.wav");
            simpleSound.Play();
            MessageBox.Show("you have a new Message");
        }
    }
}


