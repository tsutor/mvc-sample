using System.Collections.Generic;

namespace Sutor.Mvc.Sample.Web.Mappers
{
    /// <summary>
    /// Abstract base class to cover basic functionality for viewmodel-to-model (and back) mappers.
    /// </summary>
    /// <typeparam name="tmodel"></typeparam>
    /// <typeparam name="tviewModel"></typeparam>
    public abstract class BaseMapper<tmodel, tviewModel>
    {
        public abstract tviewModel ToViewModel(tmodel model);

        public abstract tmodel ToModel(tviewModel viewModel);

        public ICollection<tviewModel> ToViewModels(ICollection<tmodel> models)
        {
            var viewModels = new List<tviewModel>();

            foreach (var model in models)
            {
                viewModels.Add(ToViewModel(model));
            }

            return viewModels;
        }

        public ICollection<tmodel> ToModels(ICollection<tviewModel> viewModels)
        {
            var models = new List<tmodel>();

            foreach (var viewModel in viewModels)
            {
                models.Add(ToModel(viewModel));
            }

            return models;
        }
    }
}
