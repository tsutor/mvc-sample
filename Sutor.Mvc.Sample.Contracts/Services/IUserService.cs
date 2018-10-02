using Sutor.Mvc.Sample.Core.Models;

namespace Sutor.Mvc.Sample.Contracts.Services
{
    /// <summary>
    /// Service to perform user-related functions.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Adds a user to the system.
        /// </summary>
        /// <param name="user">The user model to be added.</param>
        /// <returns>Returns success of adding the user and post-add processing.</returns>
        bool AddUser(User user);
    }
}
