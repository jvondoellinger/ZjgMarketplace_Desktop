using FirstAppMaui.Core.Product.Response;
using FirstAppMAUI.ViewModel.Cards;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FirstAppMAUI.Views.Page;

public partial class CartPage : ContentPage
{
    public string CardButtonText { get; set; } = "Remove";
    public ObservableCollection<CartPageViewModel> Products { get; set; } = new ObservableCollection<CartPageViewModel>(CartPageViewModel.Get());

    public CartPage()
    { 
        InitializeComponent();
		BindingContext = this;
	}

    private void CollectionView_Unloaded(object sender, EventArgs e)
    {

    }
}