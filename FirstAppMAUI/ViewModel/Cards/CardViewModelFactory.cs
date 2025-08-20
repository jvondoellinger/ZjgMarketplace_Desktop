using FirstAppMaui.Core.Product.Response;
using static FirstAppMaui.Core.Product.Response.ProductApiModel;

namespace FirstAppMAUI.ViewModel.Cards
{
    internal class CardViewModelFactory
    {
        private CardViewModelFactory() { }

        public static CardViewModelFactory Instance { get; } = new CardViewModelFactory();

        public ProductViewModel FactoryCartMVVM(ProductApiModel model, Action<ProductViewModel> removeAction)
        {
            return CardViewModelMapper.Map<CartPageViewModel>(model, removeAction);
        }
        public List<ProductViewModel> FactoryCartMVVM(List<ProductApiModel> models, Action<ProductViewModel> removeAction)
        {
            var list = new List<ProductViewModel>();
            foreach (var model in models)
            {
                list.Add(FactoryCartMVVM(model, removeAction));
            }
            return list;
        }
        public ProductViewModel FactoryHomeMVVM(ProductApiModel model)
        {
            return CardViewModelMapper.Map<HomePageViewModel>(model);
        }
        public List<ProductViewModel> FactoryHomeMVVM(List<ProductApiModel> models)
        {
            var list = new List<ProductViewModel>();
            foreach (var model in models)
            {
                list.Add(FactoryHomeMVVM(model));
            }
            return list;
        }

    }
}
