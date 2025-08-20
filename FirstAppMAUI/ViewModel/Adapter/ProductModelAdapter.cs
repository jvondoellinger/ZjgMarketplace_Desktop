using FirstAppMaui.Core.Product.Response;
using FirstAppMAUI.ViewModel.Cards;

namespace FirstAppMAUI.ViewModel.Adapter
{
    internal class ProductModelAdapter
    {
        internal ProductApiModel Adapt(ProductViewModel model)
        {
            var response = new ProductApiModel()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                Amount = model.Amount,
                Paths = model.Paths
            };
            return response;
        }
    }
}
