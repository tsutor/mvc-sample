using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sutor.Mvc.Sample.Contracts;
using Sutor.Mvc.Sample.Contracts.Services;
using Sutor.Mvc.Sample.Core.Models;
using Sutor.Mvc.Sample.Domain.Services;

namespace Sutor.Mvc.Sample.Tests
{
    [TestClass]
    public class UserServiceTests
    {
        private Mock<INotificationService> notificationServiceMock;

        private Mock<IRepository<User>> userRepositoryMock;
        private Mock<IUnitOfWork> unitOfWorkMock;

        private UserService uut;

        [TestInitialize]
        public void Setup()
        {
            notificationServiceMock = new Mock<INotificationService>();

            unitOfWorkMock = new Mock<IUnitOfWork>();
            userRepositoryMock = new Mock<IRepository<User>>();
            unitOfWorkMock.Setup(u => u.UserRepository).Returns(userRepositoryMock.Object);

            uut = new UserService(unitOfWorkMock.Object, notificationServiceMock.Object);
        }

        [TestMethod]
        public void AddUser_NotificationFails_ReturnsFalse()
        {
            var testUser = new User()
            {
                FirstName = "unit test first name",
                LastName = "unit test last name"
            };

            //Mock the notification service so it returns false for our test.
            notificationServiceMock.Setup(n => n.SendNotification(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(false);

            var success = uut.AddUser(testUser);

            Assert.IsFalse(success);
        }

        [TestMethod]
        public void AddUser_NotificationIsSuccessful_ReturnsTrue()
        {
            var testUser = new User()
            {
                FirstName = "unit test first name",
                LastName = "unit test last name"
            };

            //Mock the notification service so it returns false for our test.
            notificationServiceMock.Setup(n => n.SendNotification(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var success = uut.AddUser(testUser);

            Assert.IsTrue(success);
        }
    }
}
