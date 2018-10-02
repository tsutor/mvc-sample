using Sutor.Mvc.Sample.Contracts;
using System;
using System.Collections.Generic;

namespace Sutor.Mvc.Sample.Data.Repositories
{
    public class BaseRepository<tmodel> : IRepository<tmodel>
    {
        /* Implement basic, shared repository logic that would be used across all repositories.
        * Since we don't have an actual EF implementation, I'm just going to override what I need here, but you get the idea.
        * If we had the real implementation, we'd have a reference to DBContext and could 
        * return tmodel instances or collections from these methods.
        */

        public virtual ICollection<tmodel> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual tmodel GetById()
        {
            throw new NotImplementedException();
        }

        public virtual void Add(tmodel model)
        {
            throw new NotImplementedException();
        }

        public void Remove(tmodel model)
        {
            throw new NotImplementedException();
        }
    }
}
