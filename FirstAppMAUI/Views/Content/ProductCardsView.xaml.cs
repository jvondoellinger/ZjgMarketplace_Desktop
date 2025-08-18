using FirstAppMaui.Core.Product.Singleton;

namespace FirstAppMAUI.Views.Content;

public partial class ProductCardsView : ContentView
{
	public ProductCardsView()
	{
		InitializeComponent();
	}

    private void AddProductOnCart_Clicked(object sender, EventArgs e)
    {
        var productId = ProductIdentifierView.Text;
		ProductCartSingleton.Instance.AddProductId(productId);
    }
}