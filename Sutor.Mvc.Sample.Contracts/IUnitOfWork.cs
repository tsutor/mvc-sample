using Sutor.Mvc.Sample.Core.Models;

namespace Sutor.Mvc.Sample.Contracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUnitOfWork
    {
        IRepository<User> UserRepository { get; }

        // ...Repositories for all domain models.  
        // Note that some may implement their own interface instead of IRepository if special needs arise.
    }
}
