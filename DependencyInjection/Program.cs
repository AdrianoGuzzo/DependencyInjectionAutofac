using System;
using Autofac;
using DependencyInjection.Notification;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<NotificationModule>();

            var container = containerBuilder.Build();

            var notificationService = container.Resolve<INotificationService>();
            notificationService.NotifyUsernameChanged(new Core.User("Guzzo"));
        }
    }
}
