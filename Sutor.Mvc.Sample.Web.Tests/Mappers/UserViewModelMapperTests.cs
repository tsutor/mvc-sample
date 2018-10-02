using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sutor.Mvc.Sample.Core.Models;
using Sutor.Mvc.Sample.Web.Mappers;

namespace Sutor.Mvc.Sample.Web.Tests
{
    [TestClass]
    public class UserViewModelMapperTests
    {
        private UserViewModelMapper uut;

        [TestInitialize]
        public void Setup()
        {
            uut = new UserViewModelMapper();
        }

        [TestMethod]
        public void ToViewModel_Mapping()
        {
            var user = new User()
            {
                FirstName = "unit",
                LastName = "test"
            };

            var model = uut.ToViewModel(user);

            Assert.AreEqual("unit", model.FirstName);
            Assert.AreEqual("test", model.LastName);
        }
    }
}
