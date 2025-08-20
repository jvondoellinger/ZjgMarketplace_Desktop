using FirstAppMaui.Core.Product.Response;
using static FirstAppMaui.Core.Product.Response.ProductApiModel;

namespace FirstAppMAUI.ViewModel.Cards
{
    internal class CardViewModelMapper
    {
        internal static ProductViewModel Map<ViewModel>(ProductApiModel model) where ViewModel : ProductViewModel, new()
        {
            return new ViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                Amount = model.Amount,
                Paths = model.Paths
            };
        }

        internal static ProductViewModel Map<ViewModel>(ProductApiModel model, Action<ProductViewModel> removeAction) where ViewModel : ProductViewModel, new()
        {
            return new ViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                Amount = model.Amount,
                Paths = model.Paths,
                RemoveAction = removeAction
            };
        }
    }
}

