using System;
using System.Collections.Generic;
using System.Text;

namespace Sutor.Mvc.Sample.Contracts.Services
{
    /// <summary>
    /// Service used to send notifications.
    /// </summary>
    public interface INotificationService
    {
        /// <summary>
        /// Send a notification to a person.
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="content">The Content</param>
        /// <param name="recipient">The Recipient</param>
        /// <returns></returns>
        bool SendNotification(string sender, string content, string recipient);
    }
}
