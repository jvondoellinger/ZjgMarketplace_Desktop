using static FirstAppMaui.Core.Product.Response.ProductApiResponse;

namespace FirstAppMAUI.ViewModel.Cards
{
    public class CartPageViewModel : ProductViewModel
    {
        public static List<CartPageViewModel> Get()
        {
            var list = new List<CartPageViewModel>(); // Heap
            for (int i = 0; i < 15; i++)
            {
                var p = new CartPageViewModel
                {
                    Id = i.ToString(),
                    Title = $"Titulo - Iteração: {i.ToString()}",
                    Description = $"Description to: {i.ToString()}",
                    Amount = decimal.Parse("123"),
                    ButtonText = "Remove",
                    Paths = new ImagePaths()
                    {
                        Paths = new List<string> { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTYzrJyo7zV_4vYQzjlgJav3ahooT54E8xTvg&s" }
                    }
                };
                list.Add(p);
            }
            return list;
        }
    }
}
