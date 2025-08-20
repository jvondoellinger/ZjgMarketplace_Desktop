using FirstAppMaui.Core.Product.Singleton;
using FirstAppMAUI.ViewModel.Adapter;
using static FirstAppMaui.Core.Product.Response.ProductApiModel;

namespace FirstAppMAUI.ViewModel.Cards
{
    public class CartPageViewModel : ProductViewModel
    {
        public CartPageViewModel()
        {
            ButtonText = "Remove";
            ButtonCommand = new Command(() =>
            {
                var adapter = new ProductModelAdapter();
                var adapted = adapter.Adapt(this);
                ProductCartSingleton.Instance.Remove(adapted);
                ButtonText = "Removed";
                OnPropertyChanged(nameof(ButtonText));
            });
        }
    }
}
