using Sutor.Mvc.Sample.Contracts;
using Sutor.Mvc.Sample.Core.Models;
using System.Collections.Generic;

namespace Sutor.Mvc.Sample.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IRepository<User>
    {
        
        private static List<User> testData = new List<User>()
            {
                new User()
                {
                    FirstName = "Jim",
                    LastName = "Franklin"
                },
                new User()
                {
                    FirstName = "Anthony",
                    LastName = "Smith"
                }
            };

        public override ICollection<User> GetAll()
        {
            return testData;
        }

        public override void Add(User user)
        {
            testData.Add(user);
        }
    }
}
