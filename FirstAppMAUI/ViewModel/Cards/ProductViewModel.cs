using FirstAppMaui.Core.Product.Response;
using System.ComponentModel;
using System.Windows.Input;
using static FirstAppMaui.Core.Product.Response.ProductApiModel;

namespace FirstAppMAUI.ViewModel.Cards
{
    public abstract class ProductViewModel : INotifyPropertyChanged
    {
        // Temporary method do test
        public ICommand ButtonCommand { get; protected set; }
        public Action<ProductViewModel>? RemoveAction { get; set; }
        public string ButtonText { get; protected set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public ImagePaths Paths { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
