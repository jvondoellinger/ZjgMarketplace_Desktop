using System.ComponentModel;
using static FirstAppMaui.Core.Product.Response.ProductApiResponse;

namespace FirstAppMAUI.ViewModel.Cards
{
    public class HomePageViewModel : ProductViewModel
    {
        private HomePageViewModel() {
            ButtonText = "Add on cart";
            ButtonCommand = new Command(() =>
            {
                ButtonText = "Added";
                OnPropertyChanged(nameof(ButtonText));
            });
        }

        public static List<HomePageViewModel> Get()
        {
            var list = new List<HomePageViewModel>(); // Heap
            for (int i = 0; i < 15; i++)
            {
                var p = new HomePageViewModel
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
            return list;
        }
    }
}
