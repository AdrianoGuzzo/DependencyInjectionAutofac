using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection.Core;
using DependencyInjection.Notification;

namespace DependencyInjection.FancyNotification
{
    public class FancyNotification : INotificationService
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine("teste");
            Console.WriteLine(user.Username);
        }
    }
}
