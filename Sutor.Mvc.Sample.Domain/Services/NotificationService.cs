using Sutor.Mvc.Sample.Contracts.Services;

namespace Sutor.Mvc.Sample.Domain.Services
{
    public class NotificationService : INotificationService
    {
        public bool SendNotification(string sender, string content, string recipient)
        {
            //Actually send the notification... possibly via another layer of abstraction - perhaps via EmailService.Send();

            return true;
        }
    }
}
