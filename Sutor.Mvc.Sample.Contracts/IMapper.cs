using System.Collections.Generic;

namespace Sutor.Mvc.Sample.Contracts
{
    /// <summary>
    /// Generic mapper interface for basic viewmodel-to-model (and back) mapping.
    /// </summary>
    /// <typeparam name="tmodel"></typeparam>
    /// <typeparam name="tviewModel"></typeparam>
    public interface IMapper<tmodel, tviewModel>
    {
        tviewModel ToViewModel(tmodel model);

        tmodel ToModel(tviewModel viewModel);

        ICollection<tviewModel> ToViewModels(ICollection<tmodel> models);
    }
}
