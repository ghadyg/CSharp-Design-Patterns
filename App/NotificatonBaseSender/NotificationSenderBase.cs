using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.NotificatonBaseSender
{
    public abstract class NotificationSenderBase
    {
        protected Person user;

        public NotificationSenderBase(Person person)
        {
            user = person;
           
        }

        protected abstract string GetNotificationText();
        public abstract void notify();
    }
}
