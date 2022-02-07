using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DependencyInjection.Notification;

namespace DependencyInjection
{
    public class NotificationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var notificationServiceTypes = Directory.EnumerateFiles(Environment.CurrentDirectory)
                 .Where(filename => filename.Contains("DependencyInjection") &&
                 filename.Contains("Notification.dll"))
                 .Select(filePath=>Assembly.LoadFrom(filePath))
                 .SelectMany(assembly=>assembly.GetTypes().Where(type=>typeof(INotificationService).IsAssignableFrom(type) && type.IsClass));

            foreach (var notificationServiceType in notificationServiceTypes)
            {
                builder.RegisterType(notificationServiceType).As<INotificationService>();
            }
        }
    }
}
