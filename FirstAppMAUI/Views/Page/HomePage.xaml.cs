using FirstAppMaui.Core.Product.Response;
using FirstAppMaui.Core.Product.Singleton;
using FirstAppMAUI.ViewModel.Cards;
using System.Collections.ObjectModel;
using System.Reflection;
using static FirstAppMaui.Core.Product.Response.ProductApiModel;

namespace FirstAppMAUI.Views.Page;

public partial class HomePage : ContentPage
{
    public ObservableCollection<ProductViewModel> ProductsList { get; set; }
    public HomePage()
    {
        InitializeComponent();
        LoadCartViewModel();
		BindingContext = this;
	}

    private void LoadCartViewModel()
    {
        var factory = CardViewModelFactory.Instance;
        var list = new List<ProductApiModel>(); // Heap
        for (int i = 0; i < 5; i++)
        {
            var p = new ProductApiModel
            {
                Id = i.ToString(),
                Title = $"Titulo - Iteração: {i.ToString()}",
                Description = $"Description to: {i.ToString()}",
                Amount = decimal.Parse("123"),
                Paths = new ImagePaths()
                {
                    Paths = new List<string> { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTYzrJyo7zV_4vYQzjlgJav3ahooT54E8xTvg&s" }
                }
            };
            list.Add(p);
        }
        var items = factory.FactoryHomeMVVM(list);
        ProductsList = new ObservableCollection<ProductViewModel>(items);
        OnPropertyChanged(nameof(ProductsList));
    }
}