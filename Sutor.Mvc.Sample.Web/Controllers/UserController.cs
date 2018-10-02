using Microsoft.AspNetCore.Mvc;
using Sutor.Mvc.Sample.Contracts;
using Sutor.Mvc.Sample.Contracts.Services;
using Sutor.Mvc.Sample.Core.Models;
using Sutor.Mvc.Sample.Web.Models;
using System.Collections.Generic;

namespace Sutor.Mvc.Sample.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper<User, UserViewModel> userViewModelMapper;
        private readonly IMapper<ICollection<User>, UserPageViewModel> userPageViewModelMapper;

        public UserController(IUserService userService,
            IUnitOfWork unitOfWork,
            IMapper<User, UserViewModel> userViewModelMapper,
            IMapper<ICollection<User>, UserPageViewModel> userPageViewModelMapper)
        {
            this.userService = userService;
            this.unitOfWork = unitOfWork;
            this.userPageViewModelMapper = userPageViewModelMapper;
            this.userViewModelMapper = userViewModelMapper;
        }

        public IActionResult Index()
        {
            var users = unitOfWork.UserRepository.GetAll();
            var viewModel = userPageViewModelMapper.ToViewModel(users);
            return View(viewModel);
        }

        public IActionResult Add(UserPageViewModel viewModel)
        {
            //Ensure view model is valid
            if (ModelState.IsValid)
            {
                var newUser = userViewModelMapper.ToModel(viewModel.NewUser);

                try
                {
                    var success = userService.AddUser(newUser);
                }
                catch (System.Exception)
                {
                    //Handle exception, log errors
                    throw;
                }
            }
            else
            {
                return View(viewModel);
            }

            return RedirectToAction("Index");
        }
    }
}