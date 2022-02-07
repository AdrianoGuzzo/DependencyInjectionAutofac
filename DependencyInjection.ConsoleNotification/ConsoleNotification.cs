using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection.Core;
using DependencyInjection.Notification;

namespace DependencyInjection.ConsoleNotification
{
    public class ConsoleNotification : INotificationService
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"Meu Username é: {user.Username}");
        }
    }
}
