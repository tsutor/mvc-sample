using Sutor.Mvc.Sample.Contracts;
using Sutor.Mvc.Sample.Core.Models;
using Sutor.Mvc.Sample.Data.Repositories;

namespace Sutor.Mvc.Sample.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        /* If this wasn't a demo, instead of saving to an in-memory list, this would use EF Core to save to SQL Server.
         * Since this is a demo, EF Core was not installed and Code First Migrations were not configured.  
         * Model classes in the Core project would use annotations or (preferably) the EF Core Fluent API via an implementation of IEntityTypeConfiguration<> for each domain model.
         * This would have a private DBContext property that represents the database as well as properties for a repository for each domain class / database table.
         * There would likely be an IRepository<> generic interface and Repository<> generic base class to accomplish basic data retrieval and submission.
        */

        private UserRepository userRepository;

        public IRepository<User> UserRepository
        {
            get
            {
                return userRepository ?? (userRepository = new UserRepository());
            }
        }

        public void SaveChanges()
        {
            //This would call SaveChanges() on DBContext
        }
    }
}
