using Sutor.Mvc.Sample.Contracts;
using Sutor.Mvc.Sample.Core.Models;
using Sutor.Mvc.Sample.Web.Models;
using System;
using System.Collections.Generic;

namespace Sutor.Mvc.Sample.Web.Mappers
{
    public class UserPageViewModelMapper : BaseMapper<ICollection<User>, UserPageViewModel>, IMapper<ICollection<User>, UserPageViewModel>
    {
        private readonly IMapper<User, UserViewModel> userViewModelMapper;

        public UserPageViewModelMapper(IMapper<User, UserViewModel> userViewModelMapper)
        {
            this.userViewModelMapper = userViewModelMapper;
        }

        public override ICollection<User> ToModel(UserPageViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public override UserPageViewModel ToViewModel(ICollection<User> model)
        {
            var viewModel = new UserPageViewModel
            {
                Users = userViewModelMapper.ToViewModels(model)
            };

            return viewModel;
        }
    }
}
