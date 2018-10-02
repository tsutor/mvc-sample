using Sutor.Mvc.Sample.Contracts;
using Sutor.Mvc.Sample.Core.Models;
using Sutor.Mvc.Sample.Web.Models;
using System;

namespace Sutor.Mvc.Sample.Web.Mappers
{
    public class UserViewModelMapper : BaseMapper<User, UserViewModel>, IMapper<User, UserViewModel>
    {
        public override User ToModel(UserViewModel viewModel)
        {
            var model = new User
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName
            };

            return model;
        }

        public override UserViewModel ToViewModel(User model)
        {
            var viewModel = new UserViewModel
            {
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            return viewModel;
        }
    }
}
