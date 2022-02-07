using DependencyInjection.Core;

namespace DependencyInjection.Notification
{
    public interface INotificationService
    {
        void NotifyUsernameChanged(User user);
    }
}
