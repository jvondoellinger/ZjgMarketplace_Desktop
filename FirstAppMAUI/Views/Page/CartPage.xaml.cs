using FirstAppMaui.Core.Product.Response;
using FirstAppMaui.Core.Product.Singleton;
using FirstAppMAUI.ViewModel.Adapter;
using FirstAppMAUI.ViewModel.Cards;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FirstAppMAUI.Views.Page;

public partial class CartPage : ContentPage
{
    //Ta pegando os dados do HOME e pondo no CART...
    // Talvez ter uma lista children <ProductApiResponse>
    public ObservableCollection<ProductViewModel> ProductsList { get; set; }

    public CartPage()
    {
        InitializeComponent();
        LoadCartViewModel();
        BindingContext = this;
	}
    
    private void LoadCartViewModel()
    {
        var cart = ProductCartSingleton.Instance;
        var factory = CardViewModelFactory.Instance;
        var models = factory.FactoryCartMVVM(cart.ProductModel, (vm) => ProductsList.Remove(vm));
        ProductsList = new ObservableCollection<ProductViewModel>(models);
        OnPropertyChanged(nameof(ProductsList));
    }
}