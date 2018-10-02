using System.Collections.Generic;

namespace Sutor.Mvc.Sample.Contracts
{
    public interface IRepository<tmodel>
    {
        tmodel GetById();

        ICollection<tmodel> GetAll();

        void Add(tmodel model);

        void Remove(tmodel model);
    }
}
