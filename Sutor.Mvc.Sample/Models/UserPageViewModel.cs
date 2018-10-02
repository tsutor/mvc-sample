using System.Collections.Generic;

namespace Sutor.Mvc.Sample.Web.Models
{
    public class UserPageViewModel
    {
        public UserViewModel NewUser { get; set; } = new UserViewModel();

        public ICollection<UserViewModel> Users { get; set; } = new List<UserViewModel>();
    }
}
