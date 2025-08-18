using FirstAppMaui.Core.Product.Response;
using System.Collections.ObjectModel;
using System.Reflection;

namespace FirstAppMAUI.Views;

public partial class HomePage : ContentPage
{
	public ObservableCollection<ProductApiResponse> Products { get; set; } = new ObservableCollection<ProductApiResponse>(ProductApiResponse.Get());
    public HomePage()
	{
        InitializeComponent();
		BindingContext = this;
	}
}