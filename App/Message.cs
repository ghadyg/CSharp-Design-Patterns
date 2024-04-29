using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.NotificatonBaseSender;

namespace App
{
   public class Message
    {
        public NotificationSenderBase Sender { get; set; }

        public void Send()
        {

            Sender.notify();
        }
    }
}
