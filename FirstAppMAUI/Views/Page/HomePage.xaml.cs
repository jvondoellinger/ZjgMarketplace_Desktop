using FirstAppMaui.Core.Product.Response;
using FirstAppMAUI.ViewModel.Cards;
using System.Collections.ObjectModel;
using System.Reflection;

namespace FirstAppMAUI.Views.Page;

public partial class HomePage : ContentPage
{
    public ObservableCollection<HomePageViewModel> Products { get; set; } = new ObservableCollection<HomePageViewModel>(HomePageViewModel.Get());
    public HomePage()
    {
        InitializeComponent();
		BindingContext = this;
	}
}