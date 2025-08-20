using FirstAppMaui.Core.Product.Response;
using FirstAppMaui.Core.Product.Singleton;
using FirstAppMAUI.ViewModel.Adapter;
using System.ComponentModel;
using static FirstAppMaui.Core.Product.Response.ProductApiModel;

namespace FirstAppMAUI.ViewModel.Cards
{
    public class HomePageViewModel : ProductViewModel
    {
        public HomePageViewModel() {
            ButtonText = "Add on cart";
            ButtonCommand = new Command(() =>
            {
                var adapter = new ProductModelAdapter();
                var adapted = adapter.Adapt(this);
                ProductCartSingleton.Instance.Add(adapted);
                ButtonText = "Added";
                OnPropertyChanged(nameof(ButtonText));
            });
        }
    }
}
