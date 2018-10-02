using Sutor.Mvc.Sample.Contracts;
using Sutor.Mvc.Sample.Contracts.Services;
using Sutor.Mvc.Sample.Core.Models;

namespace Sutor.Mvc.Sample.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly INotificationService notificationService;

        public UserService(IUnitOfWork unitOfWork, INotificationService notificationService)
        {
            this.unitOfWork = unitOfWork;
            this.notificationService = notificationService;
        }

        public bool AddUser(User user)
        {
            unitOfWork.UserRepository.Add(user);

            //Call into other processing - send email?  create related data?
            var processingWasSuccessful = notificationService.SendNotification("test", "test", "test");

            return processingWasSuccessful;
        }
    }
}
